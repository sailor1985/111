
-- create
CREATE TABLE EMPLOYEE (
  empId INTEGER PRIMARY KEY,
  name TEXT NOT NULL,
  age TEXT NOT NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO EMPLOYEE VALUES (0001, 'Михаил', '23', 'г.Москва, Долгопрудненское шоссе,д.6а');
INSERT INTO EMPLOYEE VALUES (0002, 'Никита', '24', 'г.Москва, Березовая аллея,д.17,к.1');
INSERT INTO EMPLOYEE VALUES (0003, 'Сергей', '25', 'г.Москва, Березовая аллея,д.17,к.31');
INSERT INTO EMPLOYEE VALUES (0004, 'Ирина', '21', 'г.Москва, ул.Хрякина,д.21');
INSERT INTO EMPLOYEE VALUES (0005, 'Маргарита', '22', 'г.Москва, б-р Академика Ландау,д.5,к.1');

-- fetch 
SELECT * FROM EMPLOYEE;