<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Team.aspx.cs" Inherits="Team" %>

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
								<h4>Add Team Member </h4>
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
                                        <asp:TextBox runat="server" ID="txt_user_designation" CssClass="form-control" Placeholder="User Designation" required="required" />
									</div>

                                     <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_user_about" CssClass="form-control" Placeholder="About User"  TextMode="MultiLine" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_facebook" CssClass="form-control" Placeholder="Facebook Link" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_twitter" CssClass="form-control" Placeholder="Twitter Link" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_linkedin" CssClass="form-control" Placeholder="Linkedin Link" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_googleplus" CssClass="form-control" Placeholder="Google Plus Link" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_instagram" CssClass="form-control" Placeholder="Instagram Link" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_pinterest" CssClass="form-control" Placeholder="Pinterst Link" required="required" />
									</div>

                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_youtube" CssClass="form-control" Placeholder="Youtube Link"  required="required" />
									</div>
                                       <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_dribble" CssClass="form-control" Placeholder="Dribble Link "  required="required" />
									</div>

                                     <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_personal_link" CssClass="form-control" Placeholder="Your Personal Link"  required="required" />
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
								<h4> View Team </h4>
							</div>
                         
                             <div class="card card-contact-list">
							<div class="agileinfo-cdr">
                               
                                <div class="card-body p-b-20">
                                    <div class="list-group">
                                        <asp:ListView runat="server" ID="lv_show_team">
                                     <ItemTemplate>
                                             <a class="list-group-item media" href="#">
                                             <div class="pull-left">
                                                <img class="lg-item-img" src='./uploaded_files/users/<%# Eval("team_image") %>' alt="" style="width:50px;">
                                            </div>
                                            <div class="media-body">
                                                <div class="pull-left">
                                                	<div class="lg-item-heading"><%# Eval("team_name") %></div>
                                                	<small class="lg-item-text"><%# Eval("team_about") %></small>
                                                </div>
                                                <div class="pull-right">
                                                	<div class="lg-item-heading"><%# Eval("team_designation") %></div>
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

