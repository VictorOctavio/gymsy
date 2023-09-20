CREATE TABLE Rol
(
  id INT NOT NULL,
  name VARCHAR(30) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Person
(
  nickname VARCHAR(7) NOT NULL,
  id INT NOT NULL,
  name VARCHAR(50) NOT NULL,
  avatar VARCHAR(400) NOT NULL,
  password VARCHAR(400) NOT NULL,
  createdAt DATE NOT NULL,
  CBU INT NOT NULL,
  rol_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (rol_id) REFERENCES Rol(id),
  UNIQUE (nickname)
);

CREATE TABLE Administrator
(
  id INT NOT NULL,
  person_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (person_id) REFERENCES Person(id)
);

CREATE TABLE Instructor
(
  id INT NOT NULL,
  person_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (person_id) REFERENCES Person(id)
);

CREATE TABLE Wallet
(
  id INT NOT NULL,
  amount FLOAT NOT NULL,
  person_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (person_id) REFERENCES Person(id)
);

CREATE TABLE TrainingPlan
(
  id INT NOT NULL,
  price FLOAT NOT NULL,
  description VARCHAR(300),
  instructor_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (instructor_id) REFERENCES Instructor(id)
);

CREATE TABLE PayType
(
  id INT NOT NULL,
  name VARCHAR(50) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Client
(
  id INT NOT NULL,
  last_expiration DATE NOT NULL,
  person_id INT NOT NULL,
  plan_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (person_id) REFERENCES Person(id),
  FOREIGN KEY (plan_id) REFERENCES TrainingPlan(id)
);

CREATE TABLE DataFisic
(
  id INT NOT NULL,
  weight INT NOT NULL,
  height INT NOT NULL,
  createdAt DATE NOT NULL,
  notes VARCHAR(1000),
  client_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (client_id) REFERENCES Client(id)
);

CREATE TABLE Image
(
  id INT NOT NULL,
  imageURL VARCHAR(500) NOT NULL,
  notes VARCHAR(500),
  datafisic_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (datafisic_id) REFERENCES DataFisic(id)
);

CREATE TABLE pay
(
  createdAt DATE NOT NULL,
  id INT NOT NULL,
  expiration DATE,
  destinatario_id INT NOT NULL,
  remitente_id INT NOT NULL,
  paytype_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (destinatario_id) REFERENCES Person(id),
  FOREIGN KEY (remitente_id) REFERENCES Person(id),
  FOREIGN KEY (paytype_id) REFERENCES PayType(id)
);