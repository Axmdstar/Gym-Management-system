https://www.sqlite.org/lang_datefunc.html

-- Example
Insert into staff_information Values('0', 'Mohamed', ' ', date('2000-04-02'), '123455', 'a@gmail.com', 'male', 'Xamar', 'Mog', 'asdf','asdf','asdf','day','Admin',200.0)

INSERT into plans VALUES(2,'40mship',12.0, 10.0,'3','Day');

CREATE TABLE customer_information (
    id VARCHAR(255) PRIMARY KEY,
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    dob TIMESTAMP,
    tell VARCHAR(255),
    email VARCHAR(255),
    sex VARCHAR(255),
    weight FLOAT,
    city VARCHAR(255),
    village VARCHAR(255),
    emmergence_contact VARCHAR(255),
    emmergency_name VARCHAR(255),
    emergency_relation VARCHAR(255)
);

CREATE TABLE plans (
    id VARCHAR(255) PRIMARY KEY,
    plan_name VARCHAR(255),
    signup_fee FLOAT,
    price FLOAT,
    staff_id VARCHAR(255),
    customer_id VARCHAR(255),
    plan_type VARCHAR(255),
    FOREIGN KEY (staff_id) REFERENCES staff_information(id),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id)
);

CREATE TABLE measurement (
    id VARCHAR(255) PRIMARY KEY,
    customer_id VARCHAR(255),
    weight FLOAT,
    date_issue TIMESTAMP,
    description VARCHAR(255),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id)
);

CREATE TABLE schedule (
    id VARCHAR(255) PRIMARY KEY,
    plan_id VARCHAR(255),
    customer_id VARCHAR(255),
    time_in TIMESTAMP,
    time_out TIMESTAMP,
    FOREIGN KEY (plan_id) REFERENCES plans(id),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id)
);

CREATE TABLE staff_information (
    id VARCHAR(255) PRIMARY KEY,
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    dob TIMESTAMP,
    tell VARCHAR(255),
    email VARCHAR(255),
    sex VARCHAR(255),
    city VARCHAR(255),
    village VARCHAR(255),
    emmergence_contact VARCHAR(255),
    emmergency_name VARCHAR(255),
    emergency_relation VARCHAR(255),
    shift VARCHAR(255),
    staff_type VARCHAR(255),
    salary FLOAT
);

CREATE TABLE users (
    id VARCHAR(255) PRIMARY KEY,
    staff_id VARCHAR(255),
    username VARCHAR(255),
    password VARCHAR(255),
    user_type VARCHAR(255),
    FOREIGN KEY (staff_id) REFERENCES staff_information(id)
);

CREATE TABLE salaries (
    id VARCHAR(255) PRIMARY KEY,
    staff_id VARCHAR(255),
    amount FLOAT,
    date TIMESTAMP,
    FOREIGN KEY (staff_id) REFERENCES staff_information(id)
);

CREATE TABLE revenue (
    id VARCHAR(255) PRIMARY KEY,
    customer_id VARCHAR(255),
    amount FLOAT,
    date_issue TIMESTAMP,
    user_id VARCHAR(255),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE attendance (
    id VARCHAR(255) PRIMARY KEY,
    sche_id VARCHAR(255),
    date TIMESTAMP,
    attendance_type VARCHAR(255),
    FOREIGN KEY (sche_id) REFERENCES schedule(id)
);