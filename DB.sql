CREATE TABLE `questionsdb`.`questions` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `category_id` INT NOT NULL,
  `status_id` INT NOT NULL,
  `title` TEXT NOT NULL,
  `text` TEXT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC));
  
  
CREATE TABLE `questionsdb`.`categories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` TEXT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC));


CREATE TABLE `questionsdb`.`question_statuses` (
  `id` INT NOT NULL,
  `name` VARCHAR(250) NOT NULL,
  `lname` VARCHAR(250) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `question_statuses_UNIQUE` (`id` ASC));

  
CREATE TABLE `questionsdb`.`comments` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `question_id` INT NOT NULL,
  `text` TEXT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC));

 
ALTER TABLE `questionsdb`.`comments` 
ADD INDEX `fk_question_comments_idx` (`question_id` ASC);
ALTER TABLE `questionsdb`.`comments` 
ADD CONSTRAINT `fk_question_comments`
  FOREIGN KEY (`question_id`)
  REFERENCES `questionsdb`.`questions` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

  
ALTER TABLE `questionsdb`.`questions` 
ADD INDEX `fk_category_questions_idx` (`category_id` ASC),
ADD INDEX `fk_qstatuses_questions_idx` (`status_id` ASC);
ALTER TABLE `questionsdb`.`questions` 
ADD CONSTRAINT `fk_category_questions`
  FOREIGN KEY (`category_id`)
  REFERENCES `questionsdb`.`categories` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_qstatuses_questions`
  FOREIGN KEY (`status_id`)
  REFERENCES `questionsdb`.`question_statuses` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
