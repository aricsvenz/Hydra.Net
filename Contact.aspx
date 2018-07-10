<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="page-wrapper">
			<div class="main-page">
				<div class="tables">
					
					<div class="bs-example widget-shadow" data-example-id="contextual-table"> 

						<table class="table"> 
                        <asp:ListView runat="server" ID="lv_show_contact" ItemPlaceholderID="ph1">
                            <LayoutTemplate>

                             <thead>
                             <tr> 
                            <th>#</th> 
                            <th>Name </th> 
                            <th>Email</th> 
                            <th>Phone</th> 
                             <th>Message</th> 

                            </tr> 

                        </thead> 
                     <asp:PlaceHolder runat="server" ID="ph1" />

                            </LayoutTemplate> 

                            <ItemTemplate>
                                <tbody> 
                                <tr class="active"> 
                                    <th scope="row">1</th> 
                                    <td><%# Eval("contact_name") %></td> 
                                    <td><%# Eval("contact_phone") %></td> 
                                    <td><%# Eval("contact_email") %></td>
                                    <td><%# Eval("contact_message") %></td>

                                </tr> 

                             
                            </tbody>
                            </ItemTemplate>
                        </asp:ListView>

                            
						</table> 
					</div>
					
				</div>
			</div>
		</div>


</asp:Content>

