<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>

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
								<h4>Add Images for Gallery </h4>
							</div>
							<div class="form-body">
								<form data-toggle="validator">
									<div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_gallery_title" CssClass="form-control" Placeholder="Gallery Title" required="required" />
									</div>
									
                                    <div class="form-group">
                                    <asp:FileUpload runat="server" ID="fu_gallery_image" />
									</div>

                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_gallery_caption" CssClass="form-control" Placeholder="Gallery Content" required="required" />
									</div>
									
                                      <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_gallery_desc" CssClass="form-control" Placeholder="Gallery Description" TextMode="MultiLine" required="required" />
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
								<h4> View Gallery </h4>
							</div>
                            <br />
                            <asp:ListView runat="server" ID="lv_show_gallery">
                                <ItemTemplate>
                                    <div class="col-sm-4">
                        <div class="user-marorm">
						<div>
                            <img src='./uploaded_files/gallery/<%# Eval("gallery_image") %>' alt='<%# Eval("gallery_image_title") %>' style="height:200px; width:100%;" />
						</div>
						<div class="malorm-bottom">
							
							 <h2><%# Eval("gallery_image_title") %></h2>
							<p><%# Eval("gallery_image_desc") %> </p>
						
						</div>
					   </div>
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

