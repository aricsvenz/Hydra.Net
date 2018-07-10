<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Testimonial.aspx.cs" Inherits="Testimonial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form runat="server" id="form1">
    <div id="page-wrapper">
			<div class="main-page">
				<div class="forms validation">
				
					
					<div class="row">
						<div class="col-md-4" data-example-id="basic-forms"> 
							<div class="form-title">
								<h4>Add Testimonials </h4>
							</div>
							<div class="form-body">
								<form data-toggle="validator">
									<div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_username" CssClass="form-control" Placeholder="User Name" required="required" />
									</div>
									
                                    <div class="form-group">
                                    <asp:FileUpload runat="server" ID="fu_user_image" />
									</div>

                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_user_title" CssClass="form-control" Placeholder="User Designation" required="required" />
									</div>

                                     <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_testimonial_content" CssClass="form-control" Placeholder="Testimonials Content" TextMode="MultiLine" required="required" />
									</div>

                                    <hr />

									<div class="form-group">
                                        <asp:Button Text="Submit" CssClass="btn btn-primary" runat="server" ID="btn_submit" OnClick="btn_submit_Click" />
									</div>
								</form>
							</div>
						</div>
						
                        <div class="col-md-8" > 
							<div class="form-title">
								<h4> View Testimonials </h4>
							</div>
                         
                             <div class="card card-contact-list">
							<div class="agileinfo-cdr">
                               
                                <div class="card-body p-b-20">
                                    <div class="list-group">
                                        <asp:ListView runat="server" ID="lv_show_testimonials">
                                     <ItemTemplate>
                                             <a class="list-group-item media" href="#">
                                             <div class="pull-left">
                                                <img class="lg-item-img" src='./uploaded_files/users/<%# Eval("testimonial_user_image") %>' alt="" style="width:50px;">
                                            </div>
                                            <div class="media-body">
                                                <div class="pull-left">
                                                	<div class="lg-item-heading"><%# Eval("testimonial_username") %></div>
                                                	<small class="lg-item-text"><%# Eval("tesimonial_text") %></small>
                                                </div>
                                                <div class="pull-right">
                                                	<div class="lg-item-heading"><%# Eval("testimonial_user_title") %></div>
                                                </div>
                                            </div>
                                        </a>
                                     </ItemTemplate>
                                 </asp:ListView>
                                    

                                   	</div>
                                </div>
                            </div>
							</div>
                              
						
					</div>
						</div>
						<div class="clearfix"> </div>	
					</div>
				</div>
			</div>
		</div>

        </form>

</asp:Content>

