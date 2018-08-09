<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

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
								<h4>About Us :</h4>
							</div>
							<div class="form-body">
								<form data-toggle="validator">
									<div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_about_title" CssClass="form-control" Placeholder="About Us Title" required="required" />
									</div>
									
                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_about_content" CssClass="form-control" Placeholder="About Us Content" TextMode="MultiLine" Rows="10" required="required" />
									</div>
									
									<div class="form-group">
                                    <asp:FileUpload runat="server" ID="fu_about_image" />
									</div>
                                    <hr />

									<div class="form-group">
                                        <asp:Button Text="Submit" CssClass="btn btn-primary" runat="server" ID="btn_submit" OnClick="btn_submit_Click" />
									</div>
								</form>
							</div>
						</div>
						
                        <div class="col-md-8"> 
							<div class="form-title">
								<h4>About Us Data </h4>
							</div>
                            <br />
                            <asp:ListView runat="server" ID="lv_show_aboutus">
                                <ItemTemplate>
                            <div class="panel panel-success"> 
                            <div class="panel-heading"> 
                                <h3 class="panel-title"> <%# Eval("about_title") %></h3> 
                             </div><br />
                                  <div class="panel-body"><img src='uploaded_files/about/<%# Eval("about_image") %>' /></div> 
                                <hr />
                             <div class="panel-body">  <%# Eval("about_content") %></div> 

						</div>
                                </ItemTemplate>
                            </asp:ListView>
						
					</div>
						</div>
						<div class="clearfix"> </div>	
					</div>
				</div>
			</div>
		</div>

        </form>
</asp:Content>

