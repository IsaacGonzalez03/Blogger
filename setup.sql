CREATE TABLE IF NOT EXISTS profiles(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  name VARCHAR(255) COMMENT 'name',
  email VARCHAR (255) COMMENT 'email',
  picture VARCHAR (255) COMMENT 'picture'
) DEFAULT CHARSET UTF8 COMMENT '';
CREATE TABLE IF NOT EXISTS blogs(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  title VARCHAR (255) COMMENT 'title',
  body VARCHAR (255) COMMENT 'body',
  imgUrl VARCHAR (255) COMMENT 'imgUrl',
  published TINYINT NOT NULL,
  creatorId VARCHAR
)