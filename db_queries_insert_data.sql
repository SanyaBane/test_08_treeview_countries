DELETE FROM `houses`;
DELETE FROM `street_types`;
DELETE FROM `streets`;
DELETE FROM `cities`;
DELETE FROM `countries`;

# ---------------

INSERT INTO `street_types` 
(`ID`, `NAME`) 
VALUES 
(1, 'Street'),
(2, 'Dead end'),
(3, 'Esplanade'),
(4, 'High Street'),
(5, 'Alley'),
(6, 'Living street'),
(7, 'Boulevard'),
(8, 'Pedway'),
(9, 'Walkway'),
(10, 'Avenue'),
(11, 'Lane');


INSERT INTO `countries`
(`ID`, `NAME`, `SHORT_NAME`)
VALUES
(1, 'United States of America', 'US'),
(2, 'Ukraine', 'UA'),
(3, 'Russia', 'RU'),
(4, 'France', 'FR'),
(5, 'Germany', 'DE'),
(6, 'Moldova', 'MD');


INSERT INTO `cities`
(`ID`, `COUNTRY_ID`, `NAME`, `AMOUNT_OF_PEOPLES`)
VALUES
(1, 1, 'New York', 8500000),
(2, 1, 'Washington', 690000),
(3, 1, 'San Fransisco', 880000),
(4, 1, 'Los Angeles', 4000000),
(5, 1, 'Chicago ', 2700000),
(6, 2, 'Kyiv', 2900000),
(7, 2, 'Odessa', 1000000),
(8, 2, 'Lviv ', 730000),
(9, 3, 'Moscow ', 12000000),
(10, 3, 'Saint Petersburg ', 5000000),
(11, 3, 'Samara ', 1200000),
(12, 3, 'Volgograd ', 1000000),
(13, 4, 'Paris ', 2200000),
(14, 4, 'Lyon ', 720000),
(15, 4, 'Marseille ', 1600000),
(16, 4, 'Nice ', 340000),
(17, 5, 'Berlin ', 3500000),
(18, 5, 'Hamburg ', 1800000),
(19, 5, 'Munich ', 1400000),
(20, 5, 'Frankfurt ', 730000);


/*
INSERT INTO `streets`
(`ID`, `NAME`, `STREET_TYPE_ID`, `CITY_ID`)
VALUES
(1, 'Some random street', 1, 1);
*/


/*
INSERT INTO `houses`
(`ID`, `NAME`, `COUNT_OF_APPARTMENTS`, `STREET_ID`)
VALUES
(1, 'Some random house', 160, 1);
*/
