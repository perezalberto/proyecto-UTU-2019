#CREATE USER 'dbaeurekabit'@'%' IDENTIFIED BY 'administrador';
#CREATE USER 'gerenteeurekabit'@'%' IDENTIFIED BY 'gerente';
#CREATE USER 'agenteeurekabit'@'%' IDENTIFIED BY 'agente';
#CREATE USER 'clienteeurekabit'@'%' IDENTIFIED BY 'cliente';

GRANT SELECT ON departamento TO 'clienteeurekabit'@'%';
GRANT SELECT ON localidad TO 'clienteeurekabit'@'%';
GRANT SELECT ON datos_cliente TO 'clienteeurekabit'@'%';
GRANT SELECT ON propiedad TO 'clienteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON visita TO 'clienteeurekabit'@'%';

GRANT SELECT ON departamento TO 'agenteeurekabit'@'%';
GRANT SELECT ON localidad TO 'agenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE, DELETE ON telefono TO 'agenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON propiedad TO 'agenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON visita TO 'agenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON persona TO 'agenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON cliente TO 'agenteeurekabit'@'%';
GRANT SELECT ON empleado TO 'agenteeurekabit'@'%';
GRANT SELECT ON sucursal TO 'agenteeurekabit'@'%';

GRANT SELECT ON departamento TO 'gerenteeurekabit'@'%';
GRANT SELECT ON localidad TO 'gerenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE, DELETE ON telefono TO 'gerenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON propiedad TO 'gerenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON visita TO 'gerenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON persona TO 'gerenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON cliente TO 'gerenteeurekabit'@'%';
GRANT SELECT, INSERT, UPDATE ON empleado TO 'gerenteeurekabit'@'%';
GRANT SELECT ON sucursal TO 'gerenteeurekabit'@'%';