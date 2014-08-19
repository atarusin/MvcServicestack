/* /
CREATE SCHEMA `QuestionsDB`;
/* */
/* /
CREATE TABLE `QuestionsDB`.`Questions` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `CategoryId` INT NOT NULL,
  `StatusId` INT NOT NULL,
  `Title` TEXT NOT NULL,
  `Content` TEXT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Questions_Id_UNIQUE` (`Id` ASC));
/* */
/* /
CREATE TABLE `QuestionsDB`.`Categories` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Title` TEXT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Categories_Id_UNIQUE` (`Id` ASC));
/* */
/* /
CREATE TABLE `QuestionsDB`.`QuestionStatuses` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(250) NOT NULL,
  `LName` VARCHAR(250) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `QuestionStatuses_Id_UNIQUE` (`Id` ASC));
/* */
/* /
CREATE TABLE `QuestionsDB`.`Comments` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `QuestionId` INT NOT NULL,
  `Content` TEXT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Comments_Id_UNIQUE` (`Id` ASC));
/* */
/* /
ALTER TABLE `QuestionsDB`.`Comments` 
ADD CONSTRAINT `fk_Question_Comments`
  FOREIGN KEY (`QuestionId`)
  REFERENCES `QuestionsDB`.`Questions` (`Id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
/* */
/* /
ALTER TABLE `QuestionsDB`.`Questions` 
ADD CONSTRAINT `fk_Category_Questions`
  FOREIGN KEY (`CategoryId`)
  REFERENCES `QuestionsDB`.`Categories` (`Id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
/* */
/* /
ALTER TABLE `QuestionsDB`.`Questions` 
ADD CONSTRAINT `fk_QStatus_Questions`
  FOREIGN KEY (`StatusId`)
  REFERENCES `QuestionsDB`.`QuestionStatuses` (`Id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
/* */
INSERT INTO `QuestionsDB`.`Categories` (`Title`) VALUES ('SQL');
  
INSERT INTO `QuestionsDB`.`QuestionStatuses` (`Name`, `LName`) VALUES ('Открыт', 'Открыть');
INSERT INTO `QuestionsDB`.`QuestionStatuses` (`Name`, `LName`) VALUES ('На голосовании', 'На голосование');
INSERT INTO `QuestionsDB`.`QuestionStatuses` (`Name`, `LName`) VALUES ('Закрыть', 'Закрыт');

INSERT INTO `QuestionsDB`.`Questions` (`CategoryId`, `StatusId`, `Title`, `Content`) VALUES ('1', '1', 'Подмножества SQL команд', 'На какие подмножества деляться все команды SQL? DDL (Data Definition Language, язык определения данных) - Команды определения данных. DCL (Data Control Language) - Команды языка управления данными. TCL (Тгаnsасtiоn Соntrol Language) - Команды языка управления транзакциями. DML (Data Manipulation Language) - Команды языка манипулирования данными.');

INSERT INTO `QuestionsDB`.`Comments` (`QuestionId`, `Content`) VALUES ('1', '+1');

