CREATE TABLE `Bicycle` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`CategoryId` INT NOT NULL,
	`Model` VARCHAR(255) NOT NULL,
	`FrameSize` INT NOT NULL,
	`ReservationId` INT NOT NULL,
	`IsAvailable` BOOLEAN NOT NULL,
	`IsInService` BOOLEAN NOT NULL,
	`StartService` DATETIME NOT NULL,
	PRIMARY KEY (`Id`)
);

CREATE TABLE `Category` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`Type` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`Id`)
);

CREATE TABLE `Reservation` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`StartReservation` DATETIME NOT NULL,
	`EndReservation` DATETIME NOT NULL,
	PRIMARY KEY (`Id`)
);

ALTER TABLE `Bicycle` ADD CONSTRAINT `Bicycle_fk0` FOREIGN KEY (`CategoryId`) REFERENCES `Category`(`Id`);

ALTER TABLE `Bicycle` ADD CONSTRAINT `Bicycle_fk1` FOREIGN KEY (`ReservationId`) REFERENCES `Reservation`(`Id`);




