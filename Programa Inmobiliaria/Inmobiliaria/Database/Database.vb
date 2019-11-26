Imports MySql.Data.MySqlClient

Public Class Database

    Private Shared instance As Database

    Private sqlConnection As MySqlConnection
    Private sqlCommand As MySqlCommand

    Private visitasInst As Visita
    Private propiedadesInst As Propiedad
    Private usuariosInst As Usuario
    Private utilidadesInst As Localidades
    Private sucursalInst As Sucursal

    Private Sub New()
        sqlConnection = New MySqlConnection
        sqlCommand = New MySqlCommand
    End Sub

    Public Shared ReadOnly Property GetInstance As Database
        Get
            If instance Is Nothing Then
                instance = New Database
            End If
            Return instance
        End Get
    End Property

    Public Shared Sub ClearInstance()
        instance.sqlConnection.Close()
        instance = New Database
    End Sub

    Public Sub Close()
        If sqlConnection.State = ConnectionState.Open Then
            sqlConnection.Close()
        End If
    End Sub

    Private Function CheckConnection() As Boolean
        If sqlConnection.State <> ConnectionState.Open Then
            Try
                sqlConnection.Open()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

    Public Sub LoginSQL(uid As String, passwd As String)
        LoginSQL(My.Settings.database, uid, passwd)
    End Sub

    Public Sub LoginSQL(database As String, uid As String, passwd As String)
        Close()
        sqlConnection.ConnectionString =
            "server=" + My.Settings.server +
            ";port=" + My.Settings.port +
            ";database=" + database +
            ";user=" + uid +
            ";password=" + passwd
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
    End Sub

    Public Function SQL(sql_text As String) As DataTable
        If sql_text = "" Or Not CheckConnection() Then
            Return New DataTable
        End If
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        sqlCommand.CommandText = sql_text
        sqlCommand.ExecuteNonQuery()
        adapter.SelectCommand = sqlCommand
        adapter.Fill(table)
        Return table
    End Function

    ''' <summary>
    ''' SQL (Consulta a la base de datos)
    ''' </summary>
    ''' <returns>MySqlDataAdapter con er resultado de la consulta</returns>
    Public Function SQL(ByRef command As MySqlCommand) As DataTable
        If Not CheckConnection() Then
            Return New DataTable
        End If
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        command.Connection = sqlConnection
        command.ExecuteNonQuery()
        adapter.SelectCommand = command
        adapter.Fill(table)
        Return table
    End Function

    ''' <summary>
    ''' DML (Data Manipulation Language)
    ''' </summary>
    Public Function DML(dml_text As String) As Boolean
        If dml_text = "" Then
            Return True
        End If
        If Not CheckConnection() Then
            Return False
        End If
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = dml_text
        Try
            If sqlCommand.ExecuteNonQuery() <> 0 Then
                Return True
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function

    ''' <summary>
    ''' DML (Data Manipulation Language)
    ''' Ejecuta un arreglo de consultas DML
    ''' </summary>
    Public Function DML(dmlarr() As String) As Boolean
        If Not CheckConnection() Then
            Return False
        End If
        sqlCommand.Connection = sqlConnection
        Try
            For Each dmlItem In dmlarr
                sqlCommand.CommandText = dmlItem
                sqlCommand.ExecuteNonQuery()
            Next
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function DML(ByRef command As MySqlCommand) As Boolean
        If Not CheckConnection() Then
            Return False
        End If
        command.Connection = sqlConnection
        Try
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Usuarios() As Usuario
        If usuariosInst Is Nothing Then
            usuariosInst = New Usuario()
        End If
        Return usuariosInst
    End Function

    Public Function Propiedades() As Propiedad
        If propiedadesInst Is Nothing Then
            propiedadesInst = New Propiedad()
        End If
        Return propiedadesInst
    End Function

    Public Function Visitas() As Visita
        If visitasInst Is Nothing Then
            visitasInst = New Visita()
        End If
        Return visitasInst
    End Function

    Public Function Sucursales() As Sucursal
        If sucursalInst Is Nothing Then
            sucursalInst = New Sucursal()
        End If
        Return sucursalInst
    End Function

    Public Function Utilidades() As Localidades
        If utilidadesInst Is Nothing Then
            utilidadesInst = New Localidades()
        End If
        Return utilidadesInst
    End Function

    Public Function Telefonos() As Telefonos
        Return New Telefonos()
    End Function

End Class
