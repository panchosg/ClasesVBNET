USE world;
-- SELECT * FROM country WHERE Name = "Venezuela";
-- SELECT * FROM country ORDER BY LifeExpectancy;
-- SELECT * FROM country WHERE code2 LIKE "Ua%";
/* SELECT * FROM country WHERE IndepYear >= 1950 AND IndepYear <=1960  order by Name;
SELECT * FROM country WHERE IndepYear between 1950 and 1960 order by Name; */
-- SELECT * FROM country WHERE name = "Benin" OR name = "Cambodia";
-- select * from country where governmentForm = "Republic" And LifeExpectancy >50.0 order by LifeExpectancy;
-- SELECT * FROM country where Continent in ("Africa","Asia","Oceania");
-- SELECT * FROM country where IndepYear in (1950,1960,1970) order by Continent;
-- SELECT * FROM country WHERE NOT GovernmentForm = "Republic" AND NOT GovernmentForm = "Federal Republic";
-- SELECT * FROM country WHERE GovernmentForm like "%Socialist%";

-- USE pruebavb;
/*INSERT INTO productos (codigo_producto, nombre_producto, tipo, descripcion, precio, fabrica)
VALUES (0,"Producto2",'aceitePie','loción para las axilas',1234,3);*/
/*INSERT INTO productos (nombre_producto, tipo, descripcion, precio, fabrica)
VALUES ("Producto4",'aceitePie','loción para las axilas',1234,3);*/
-- INSERT INTO productos VALUES (0,"Producto5",'aceitePie3','loción para lOS PIES',12,5);

-- USE world;
-- SELECT * FROM world.city;
-- SELECT COUNT(Name) AS CantidadCiudades, CountryCode FROM city group by CountryCode order by CantidadCiudades desc LIMIT 1000;


-- USE world;
-- SELECT * FROM Country LIMIT 1000;
-- SELECT AVG(LifeExpectancy), Region FROM country group by Region limit 1000; 
-- SELECT AVG(LifeExpectancy) AS EsperanzaVidaPromedio, GovernmentForm, Region FROM country group by GovernmentForm order by EsperanzaVidaPromedio  limit 1000; 
-- SELECT Max(LifeExpectancy) AS EsperanzaVidaMax, GovernmentForm, Region FROM country group by GovernmentForm order by EsperanzaVidaMax  limit 1000; 
-- SELECT Min(LifeExpectancy) AS EsperanzaVidaMin, GovernmentForm, Region, Name FROM country WHERE GovernmentForm LIKE '%Socialistic%' group by GovernmentForm order by EsperanzaVidaMin  limit 1000; 
-- SELECT COUNT(Name) AS CantidadPaises, Region FROM Country GROUP BY Region ORDER BY CantidadPaises desc LIMIT 1000;

USE pruebavb;
-- SELECT * FROM pruebavb.productos;
-- DELETE FROM productos WHERE codigo_producto = 6;
-- DELETE FROM productos WHERE tipo = 'aceitePie';
-- DELETE FROM productos WHERE codigo_producto IN (2,4);
-- DROP TABLE productos; PROHIBIDO, VACIA TODA LA TABLA DE LA BASE DE DATOS!!
-- DELETE FROM productos WHERE codigo_producto NOT IN (2,4);
-- DELETE FROM productos; PROHBIDO!!, BORRA TODOS LOS REGISTROS!!!!
-- UPDATE productos SET tipo='', precio=4321 WHERE codigo_producto = 4;
-- UPDATE productos SET tipo='', precio=4321;


