<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="events.aspx.cs" Inherits="events" %>

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
								<h4>Events</h4>
							</div>
							<div class="form-body">
								<form data-toggle="validator">
									<div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_event_title" CssClass="form-control" Placeholder="Event Title" required="required" />
									</div>
								
                                    	<div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_event_content" CssClass="form-control" Placeholder="Event Description" TextMode="MultiLine" Rows="10" required="required" />
									</div>
									
									<div class="form-group">
                                    <asp:FileUpload runat="server" ID="fu_event_image" />
									</div>

                                    <div class="form-group">
                                      <asp:TextBox runat="server" TextMode="Time" ID="txt_event_time" CssClass="form-control"  required="required" />
									</div>
									
                                     <div class="form-group">
                                      <asp:TextBox runat="server" TextMode="Date" ID="txt_event_date" CssClass="form-control"  required="required" />
									</div>
									
									<div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_event_place" CssClass="form-control" Placeholder="Event Place" required="required" />
									</div>
                                     
                                  <div class="form-group">
                                  <asp:TextBox runat="server" ID="txt_event_city" CssClass="form-control" Placeholder="Event City" required="required" />
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
								<h4>Events Details </h4>
							</div>
                            <br />
                            <div class="w3-agile-crd widgettable">
                            <div class="card">
                                <div class="card-body card-padding">

                                      
                                        <div class="widget-body">
                                            <div class="streamline">
                                     <asp:ListView runat="server" ID="lv_show_events">
                                    <ItemTemplate>  
                                         <div class="sl-item sl-danger">
                                                    <div class="sl-content">
                                                        <strong class="text-muted"><%# Eval("event_date") %> | <%# Eval("event_time") %></strong>
                                                        <h3 style="margin-top:12px;"><%# Eval("event_title") %></h3><br />
                                                        <p><%# Eval("event_details") %></p>
                                                         <small><h5><%# Eval("event_place") %> | <%# Eval("event_city") %></h5></small>
                                                    </div>
                                             <hr />
                                                </div>
                                    </ItemTemplate>
                                </asp:ListView>
                                               
                                         
                                                   </div>
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

