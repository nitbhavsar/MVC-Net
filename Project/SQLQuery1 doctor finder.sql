Create table tblAdmin(
admin_id int primary key identity(1,1),
first_name varchar(25),
last_name varchar(25),
email_id varchar(50),
psw varchar(25))

create table tblState(
state_id int primary key identity(1,1),
state_name varchar(20))

create table tblCity(
city_id int primary key identity(1,1),
city_name varchar(25),
state_id int foreign key references tblState(state_id))

create table tblHospital(
hospital_id int primary key identity(1,1),
hospital_name varchar(50),
h_address varchar(100),
state_id int foreign key references tblState(state_id),
city_id int foreign key references tblCity(city_id),
contact_no varchar(10),
profile_image varbinary(max))

create table tblDoctor(
doctor_id int primary key identity(1,1),
doctor_name varchar(50),
degree varchar(50),
speciality varchar(50),
profile_image varbinary(max),
hospital_id int foreign key references tblHospital(hospital_id))

create table tblPatient(
patient_id int primary key identity(1,1),
first_name varchar(25),
last_name varchar(25),
dob date,
email varchar(50),
psw varchar(25),
mobile_no varchar(10),
profile_image varbinary(max)
)

create table tblAppointment(
appointment_id int primary key identity(1,1),
patient_id int foreign key references tblPatient(patient_id),
doctor_id int foreign key references tblDoctor(doctor_id),
hospital_id int foreign key references tblHospital(hospital_id),
date_time date,
appointment_status varchar(25))