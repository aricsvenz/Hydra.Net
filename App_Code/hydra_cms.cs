using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for wbm
/// </summary>
public class hydra_cms
{

    SqlConnection con = null;
    public int user_id { get; set; }
    public string admin_name { get; set;}
	public string admin_email  { get; set; }
	public string admin_phone { get; set; }
    public string admin_password { get; set; }
    public string admin_image { get; set; }

    // about us variables

    public int about_id { get; set; }
    public string about_title { get; set; }
    public string about_content { get; set; }
    public string about_image { get; set; }
    public string about_imagepath { get; set; }


    //testimonials variables

    public int testimonial_id { get; set; }
    public string testimonial_username { get; set; }
    public string testimonial_user_title { get; set; }
    public string testimonial_text { get; set; }
    public string testmonial_date { get; set; }
    public string testimonial_time { get; set; }
    public string testimonial_user_image { get; set; }
    public string testimonial_user_imagepath { get; set; }

    //services variables

    public int service_id { get; set; }
    public string service_title { get; set; }
    public string service_description { get; set; }
    public string service_image { get; set; }
    public string service_imagepath { get; set; }

    // contact variable
    public int contact_id { get; set; }
    public string contact_phone { get; set; }
    public string contact_email { get; set; }
    public string contact_message { get; set; }


    // Enquiry variable
    public int enquiry_id { get; set; }
    public int enquiry_for_id { get; set; }
    public string enquiry_for { get; set; }
    public string enquiry_username { get; set; }
    public string enquiry_user_phone { get; set; }
    public string enquiry_user_email { get; set; }
    public string enquiry_message { get; set; }

    
    //team variables

    public int team_id { get; set; }
    public string team_name { get; set; }
    public string team_designation { get; set; }
    public string team_about { get; set; }
    public string team_image { get; set; }
    public string team_imagepath { get; set; }
    public string team_facebook { get; set; }
    public string team_twitter { get; set; }
    public string team_linkdin { get; set; }
    public string team_googleplus { get; set; }
    public string team_instagram { get; set; }
    public string team_pinterest { get; set; }
    public string team_youtube { get; set; }
    public string team_dribble { get; set; }
    public string team_personal_link { get; set; }


    // social media //

    public string social_media_id { get; set; }
    public string facebook { get; set; }
    public string twitter { get; set; }
    public string linkdin { get; set; }
    public string googleplus { get; set; }
    public string instagram { get; set; }
    public string pinterest { get; set; }
    public string youtube { get; set; }
    public string dribble { get; set; }
    public string personal_link { get; set; }



    //-----------------

    // Portfolio variables
    public int portfolio_id { get; set; }
    public string portfolio_title { get; set; }
    public string portfolio_image { get; set; }
    public string portfolio_imagepath { get; set; }
    public string portfolio_description { get; set; }

    // Event variables
    public int event_id { get; set; }
    public string event_title { get; set; }
    public string event_details { get; set; }
    public string event_image { get; set; }
    public string event_image_path { get; set; }
    public string event_date { get; set; }
    public string event_time { get; set; }
    public string event_place { get; set; }
    public string event_city { get; set; }

    // gallery variables

    public int galley_id { get; set; }
    public string gallery_title { get; set; }
    public string gallery_image_desc { get; set; }
    public string gallery_image { get; set; }
    public string gallery_imagepath { get; set; }
    public string gallery_image_title { get; set; }

    // clients variables
    public int client_id { get; set; }
    public string client_name { get; set; }
    public string client_logo { get; set; }
  
    
	public hydra_cms()
	{
         con = new SqlConnection(ConfigurationManager.ConnectionStrings["hydra_cms"].ConnectionString);
	}


    // ---- Administrator management --------------

    public int insert_admin()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_createadmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@admin_name", admin_name);
            cmd.Parameters.AddWithValue("@admin_email", admin_email);
            cmd.Parameters.AddWithValue("@admin_password", admin_password);
            cmd.Parameters.AddWithValue("@admin_phone", admin_phone);
            cmd.Parameters.AddWithValue("@admin_image", admin_image);
   
            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {
            
            throw ex;
        }
        finally
        {
                con.Close();
        }
    } // add new admin

    public DataTable login()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from administrator where admin_email=@admin_email AND admin_password=@admin_password";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@admin_email", admin_email);
            cmd.Parameters.AddWithValue("@admin_password", admin_password);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            
               
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    } // Admin login methods

    public DataTable get_maxid()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select MAX(admin_id) from administrator";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    } // get id of latest entry

    public DataTable get_idbyemail()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from administrator where admin_email=@admin_email";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@admin_email",admin_email);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    } // get user id by email
   
    //----------------------------
  
    //---------  About Us Methods ---------------

    public int insert_about()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_about";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@about_title", about_title);
            cmd.Parameters.AddWithValue("@about_content", about_content);
            cmd.Parameters.AddWithValue("@about_image", about_image);
            cmd.Parameters.AddWithValue("@about_imagepath", about_imagepath);
         

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    } 

    public DataTable show_about()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from About_us";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
           

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_about_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from About_us where about_id=@about_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@about_id",about_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    } 



    // --------- insert Gallery -------------

    public int insert_gallery()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_gallery";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@gallery_title", gallery_title);
            cmd.Parameters.AddWithValue("@gallery_image", gallery_image);
            cmd.Parameters.AddWithValue("@gallery_imagepath", gallery_imagepath);
            cmd.Parameters.AddWithValue("@gallery_image_title", gallery_image_title);
            cmd.Parameters.AddWithValue("@gallery_image_desc",gallery_image_desc);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_gallery()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from gallery_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_gallery_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from gallery_management where gallery_id=@gallery_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@gallery_id", galley_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    } 

    //--------------------------------------------




    // --------- Services -------------

    public int insert_services()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_service";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@service_title", service_title);
            cmd.Parameters.AddWithValue("@service_Description", service_description);
            cmd.Parameters.AddWithValue("@service_image", service_image);
            cmd.Parameters.AddWithValue("@service_imagepath", service_imagepath);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_services()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from service_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_service_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from service_management where service_id=@service_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@service_id", service_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------


    // ---------  testimonials -------------

    public int insert_testimonials()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_testmonial";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@testimonial_username", testimonial_username);
            cmd.Parameters.AddWithValue("@testimonial_user_title", testimonial_user_title);
            cmd.Parameters.AddWithValue("@tesimonial_text", testimonial_text);
            cmd.Parameters.AddWithValue("@testmonial_date", testmonial_date);
            cmd.Parameters.AddWithValue("@testimonial_time", testimonial_time);
            cmd.Parameters.AddWithValue("@testimonial_user_image", testimonial_user_image);
            cmd.Parameters.AddWithValue("@testimonial_user_imagepath", testimonial_user_imagepath);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_testimonials()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from testimonials_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_testimonials_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from testimonials_management where testimonial_id=@testimonial_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@testimonial_id", testimonial_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------

    // ---------  Enquiry Management -------------

    public int insert_enquiry()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_enquiry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@enquiry_for_id", enquiry_for_id );
            cmd.Parameters.AddWithValue("@enquiry_for", enquiry_for);
            cmd.Parameters.AddWithValue("@enquiry_username", enquiry_username);
            cmd.Parameters.AddWithValue("@enquiry_user_phone", enquiry_user_phone);
            cmd.Parameters.AddWithValue("@enquiry_user_email", enquiry_user_email);
            cmd.Parameters.AddWithValue("@enquiry_message", enquiry_message);
         
            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_enquiry()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from enquiry";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_enquiry_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from enquiry where enquiry_id=@enquiry_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@enquiry_id", enquiry_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------

    // ---------  Event Management -------------

    public int insert_events()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_insert_event";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@event_title", event_title);
            cmd.Parameters.AddWithValue("@event_details", event_details);
            cmd.Parameters.AddWithValue("@event_image", event_image);
            cmd.Parameters.AddWithValue("@event_image_path", event_image_path);
            cmd.Parameters.AddWithValue("@event_date", event_date);
            cmd.Parameters.AddWithValue("@event_time", event_time);
            cmd.Parameters.AddWithValue("@event_place", event_place);
            cmd.Parameters.AddWithValue("@event_city", event_city);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_events()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from event_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_events_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from event_management where event_id=@event_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@event_id", event_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------



    // ---------  Team Management -------------

    public int insert_team()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_team";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@team_name", team_name);
            cmd.Parameters.AddWithValue("@team_designation", team_designation);
            cmd.Parameters.AddWithValue("@team_about", team_about);
            cmd.Parameters.AddWithValue("@team_image", team_image);
            cmd.Parameters.AddWithValue("@team_imagepath", team_imagepath);
            cmd.Parameters.AddWithValue("@team_facebook", team_facebook);
            cmd.Parameters.AddWithValue("@team_twitter", team_twitter);
            cmd.Parameters.AddWithValue("@team_linkdin", team_linkdin);
            cmd.Parameters.AddWithValue("@team_googleplus", team_googleplus);
            cmd.Parameters.AddWithValue("@team_instagram", team_instagram);
            cmd.Parameters.AddWithValue("@team_pinterest", team_pinterest);

            cmd.Parameters.AddWithValue("@team_youtube", team_youtube);
            cmd.Parameters.AddWithValue("@team_dribble", team_dribble);
            cmd.Parameters.AddWithValue("@team_personal_link", team_personal_link);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_team()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from team_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_team_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from team_management where team_id=@team_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@team_id", team_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------

    // ---------  Social Media Management -------------

    public int insert_social_media()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_socialmedia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@facebook", facebook);
            cmd.Parameters.AddWithValue("@twitter", twitter);
            cmd.Parameters.AddWithValue("@linkdin", linkdin);
            cmd.Parameters.AddWithValue("@googleplus", googleplus);
            cmd.Parameters.AddWithValue("@instagram", instagram);
            cmd.Parameters.AddWithValue("@pinterest", pinterest);
            cmd.Parameters.AddWithValue("@youtube", youtube);
            cmd.Parameters.AddWithValue("@dribble", dribble);
            cmd.Parameters.AddWithValue("@personal_link", personal_link);
            
            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_social_media()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from social_media_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_socialmedia_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from social_media_management where social_media_id=@social_media_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@social_media_id", social_media_id );

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------

    // ---------  contact Management -------------

    public int insert_contact()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_contact";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@contact_name", enquiry_username);
            cmd.Parameters.AddWithValue("@contact_phone", contact_phone);
            cmd.Parameters.AddWithValue("@contact_email", contact_email);
            cmd.Parameters.AddWithValue("@contact_message", contact_message);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_contact()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from contact";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_contact_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from contact where contact_id=@contact_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@contact_id", contact_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------


    // ---------  Clients Management -------------

    public int insert_clients()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_insertclient";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@client_name", client_name);
            cmd.Parameters.AddWithValue("@client_logo", client_logo);
         
            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_clients()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from client_management";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_clients_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from client_management where client_id=@client_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@client_id", client_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------


    // ---------  Portfolio Management -------------

    public int insert_portfolio()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_insert_portfolio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@portfolio_title", portfolio_title);
            cmd.Parameters.AddWithValue("@portfolio_image", portfolio_image);
            cmd.Parameters.AddWithValue("@portfolio_imagepath", portfolio_imagepath);
            cmd.Parameters.AddWithValue("@portfolio_description", portfolio_description);

            int i = cmd.ExecuteNonQuery();

            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_portfolio()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from portfolio";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable show_portfolio_by_id()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from portfolio where portfolio_id=@portfolio_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@portfolio_id", portfolio_id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //--------------------------------------------

}