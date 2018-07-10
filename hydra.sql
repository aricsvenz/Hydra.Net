Create database hydra_net


create table administrator
(
 admin_id int identity(1,1),
 admin_name varchar (max),
 admin_email varchar (max),
 admin_phone varchar (max),
 admin_password varchar (max),
 admin_image varchar (max),
 )

create proc sp_createadmin
 @admin_name varchar (max),
 @admin_email varchar (max),
 @admin_phone varchar (max),
 @admin_password varchar (max),
 @admin_image varchar (max)
as
begin

insert into administrator(admin_name,admin_email,admin_phone,admin_password,admin_image)
values(@admin_name,@admin_email,@admin_phone,@admin_password,@admin_image)
end
go


create table About_us
(
	about_id int identity(1,1),
	about_title varchar (max),
	about_content varchar (max),
	about_image varchar (max),
	about_imagepath varchar (max)
)


create proc insert_about
    @about_title varchar (max),
	@about_content varchar (max),
	@about_image varchar (max),
	@about_imagepath varchar (max)
	as
	begin
	insert into About_us(about_title,
	about_content,
	about_image,
	about_imagepath)values(@about_title,
	@about_content,
	@about_image,
	@about_imagepath)
	end
	go


Create table gallery_management
(
  gallery_id int identity(1,1),
  gallery_title varchar (max),
  gallery_image varchar (max),
  gallery_imagepath varchar (max),
  gallery_image_title varchar (max),
  gallery_image_desc varchar (max)
)


create proc insert_gallery
  @gallery_title varchar (max),
  @gallery_image varchar (max),
  @gallery_imagepath varchar (max),
  @gallery_image_title varchar (max),
  @gallery_image_desc varchar (max)

as
begin
insert into gallery_management(gallery_title,
  gallery_image,
  gallery_imagepath,
  gallery_image_title,
  gallery_image_desc)values(@gallery_title,
  @gallery_image,
  @gallery_imagepath,
  @gallery_image_title,
  @gallery_image_desc
)
end
go


create table testimonials_management
(
	testimonial_id int identity(1,1),
	testimonial_username varchar (max),
	testimonial_user_title varchar (max),
	tesimonial_text varchar (max),
	testmonial_date varchar (max),
	testimonial_time varchar (max),
	testimonial_user_image varchar (max),
	testimonial_user_imagepath varchar (max)

)


create proc insert_testmonial
	@testimonial_username varchar (max),
	@testimonial_user_title varchar (max),
	@tesimonial_text varchar (max),
	@testmonial_date varchar (max),
	@testimonial_time varchar (max),
	@testimonial_user_image varchar (max),
	@testimonial_user_imagepath varchar (max)

as
begin
insert into testimonials_management(
	testimonial_username,
	testimonial_user_title,
	tesimonial_text,
	testmonial_date,
	testimonial_time,
	testimonial_user_image,
	testimonial_user_imagepath)values(@testimonial_username,
	@testimonial_user_title,
	@tesimonial_text,
	@testmonial_date,
	@testimonial_time,
	@testimonial_user_image,
	@testimonial_user_imagepath)
end
go

create table service_management
(
	service_id int identity(1,1),
	service_title varchar (max),
	service_Description varchar (max),
	service_image  varchar (max),
	service_imagepath varchar (max)
)

create proc insert_service
    @service_title varchar (max),
	@service_description varchar (max),
	@service_image varchar (max),
	@service_imagepath varchar (max)
	as
	begin
	insert into service_management(service_title,
	service_description,
	service_image,
	service_imagepath)values( @service_title,
	@service_description,
	@service_image,
	@service_imagepath )
	end
	go

	
create table enquiry(
enquiry_id int identity(1,1),
enquiry_for_id int,
enquiry_for varchar (max),
enquiry_username varchar (max),
enquiry_user_phone varchar (max),
enquiry_user_email varchar (max),
enquiry_message varchar (max)
)

create proc insert_enquiry
@enquiry_for_id int,
@enquiry_for varchar (max),
@enquiry_username varchar (max),
@enquiry_user_phone varchar (max),
@enquiry_user_email varchar (max),
@enquiry_message varchar (max)
as
begin
insert into enquiry (enquiry_for_id,
enquiry_for,
enquiry_username,
enquiry_user_phone,
enquiry_user_email,
enquiry_message)values (@enquiry_for_id,
@enquiry_for,
@enquiry_username,
@enquiry_user_phone,
@enquiry_user_email,
@enquiry_message)
end
go

create table contact
(contact_id int identity(1,1),
contact_name varchar (max),
contact_phone varchar (max),
contact_email varchar (max),
contact_message varchar (max)
)

create proc insert_contact
@contact_name varchar (max),
@contact_phone varchar (max),
@contact_email varchar (max),
@contact_message varchar (max)
as
begin

insert into contact (contact_name,
contact_phone,
contact_email,
contact_message) values (@contact_name,
@contact_phone ,
@contact_email,
@contact_message 
)end
go


create table portfolio(
 portfolio_id int identity(1,1),
 portfolio_title varchar (max),
 portfolio_image varchar (max),
 portfolio_imagepath varchar (max),
 portfolio_description varchar(max),
)

create proc sp_insert_portfolio
 @portfolio_title varchar (max),
 @portfolio_image varchar (max),
 @portfolio_imagepath varchar (max),
 @portfolio_description varchar(max)
as
begin
insert into portfolio( portfolio_title,
 portfolio_image,
 portfolio_imagepath,
 portfolio_description)values ( @portfolio_title,
 @portfolio_image,
 @portfolio_imagepath,
 @portfolio_description)
end
go

create table team_management(
team_id int identity(1,1),
team_name varchar (max),
team_designation varchar (max),
team_about varchar (max),
team_image varchar (max),
team_imagepath varchar (max),
team_facebook varchar (max),
team_twitter varchar (max),
team_linkdin varchar (max),
team_googleplus varchar (max),
team_instagram varchar (max),
team_pinterest varchar (max),
team_youtube varchar (max),
team_dribble varchar (max),
team_personal_link varchar (max)
)

create proc insert_team
@team_name varchar (max),
@team_designation varchar (max),
@team_about varchar (max),
@team_image varchar (max),
@team_imagepath varchar (max),
@team_facebook varchar (max),
@team_twitter varchar (max),
@team_linkdin varchar (max),
@team_googleplus varchar (max),
@team_instagram varchar (max),
@team_pinterest varchar (max),
@team_youtube varchar (max),
@team_dribble varchar (max),
@team_personal_link varchar (max)
as
begin
insert into team_management(team_name,
team_designation,
team_about,
team_image,
team_imagepath,
team_facebook,
team_twitter,
team_linkdin ,
team_googleplus,
team_instagram ,
team_pinterest,
team_youtube ,
team_dribble,
team_personal_link
)values (@team_name,
@team_designation,
@team_about,
@team_image,
@team_imagepath,
@team_facebook,
@team_twitter,
@team_linkdin ,
@team_googleplus,
@team_instagram ,
@team_pinterest,
@team_youtube ,
@team_dribble,
@team_personal_link)
end
go

create table social_media_management
(social_media_id int identity,
facebook varchar (max),
twitter varchar (max),
linkdin varchar (max),
googleplus varchar (max),
instagram varchar (max),
pinterest varchar (max),
youtube varchar (max),
dribble varchar (max),
personal_link varchar (max)
)

create proc insert_socialmedia
@facebook varchar (max),
@twitter varchar (max),
@linkdin varchar (max),
@googleplus varchar (max),
@instagram varchar (max),
@pinterest varchar (max),
@youtube varchar (max),
@dribble varchar (max),
@personal_link varchar (max)
as
begin
insert into social_media_management(facebook,
twitter ,
linkdin,
googleplus,
instagram,
pinterest,
youtube,
dribble,
personal_link)values (@facebook,
@twitter ,
@linkdin,
@googleplus,
@instagram,
@pinterest,
@youtube,
@dribble,
@personal_link)
end
go


create table client_management(
client_id varchar (max),	
client_name varchar (max),
client_logo varchar (max),
)

create proc sp_insertclient
@client_name varchar (max),
@client_logo varchar (max)
as
begin
insert into client_management(client_name,client_logo)values(@client_name,@client_logo)
end
go



create table event_management(
	event_id int identity (1,1),
	event_title varchar (max),
	event_details varchar (max),
	event_image varchar (max),
	event_image_path varchar (max),
	event_date varchar (max),
	event_time varchar (max),
	event_place varchar (max),
	event_city varchar (max)
)



alter proc sp_insert_event
	@event_title varchar (max),
	@event_details varchar (max),
	@event_image varchar (max),
	@event_image_path varchar (max),
	@event_date varchar (max),
	@event_time varchar (max),
	@event_place varchar (max),
	@event_city varchar (max)

as
begin
insert into event_management (event_title,
	event_details,
	event_image,
	event_image_path,
	event_date,
	event_time,
	event_place,
	event_city) values (@event_title,
	@event_details,
	@event_image,
	@event_image_path,
	@event_date,
	@event_time,
	@event_place,
	@event_city)
end
go


