Public Class ListMenuButton
    Inherits Button
    Private isSelected As Boolean = False
    Private currentLeftBarColor As Color

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Property BgColorDefault As Color
    Public Property BgColorHover As Color
    Public Property BgColorClick As Color
    Public Property BgColorSelected As Color

    Public Property LeftBarColorDefault As Color
    Public Property LeftBarColorHover As Color
    Public Property LeftBarColorSelected As Color

    Public Property Selected As Boolean
        Get
            Return isSelected
        End Get
        Set(value As Boolean)
            isSelected = value
            ButtonMenuList_Selected()
        End Set
    End Property

    Private Sub ButtonMenuList_Selected()
        If isSelected Then
            BackColor = BgColorSelected
            currentLeftBarColor = LeftBarColorSelected
            FlatAppearance.MouseOverBackColor = BgColorSelected
            FlatAppearance.MouseDownBackColor = BgColorSelected
        Else
            BackColor = BgColorDefault
            currentLeftBarColor = LeftBarColorDefault
            FlatAppearance.MouseOverBackColor = BgColorHover
            FlatAppearance.MouseDownBackColor = BgColorClick
        End If
    End Sub

    Private Sub InitializeComponent()
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        FlatAppearance.MouseOverBackColor = BgColorHover
        FlatAppearance.MouseDownBackColor = BgColorClick
        ImageAlign = ContentAlignment.MiddleLeft
        TextAlign = ContentAlignment.MiddleLeft
        TextImageRelation = TextImageRelation.ImageBeforeText
        Margin = New Padding(0, 0, 0, 0)
        Padding = New Padding(15, 0, 0, 0)
    End Sub

    Private Sub ButtonMenuList_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Brush As New Drawing.SolidBrush(currentLeftBarColor)
        e.Graphics.FillRectangle(Brush, 0, 0, 10, Height)
    End Sub

    Private Sub ListMenuButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If isSelected Then
            Return
        End If
        currentLeftBarColor = LeftBarColorHover
    End Sub

    Private Sub ListMenuButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If isSelected Then
            Return
        End If
        currentLeftBarColor = LeftBarColorDefault
    End Sub
End Class
