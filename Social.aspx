<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Social.aspx.cs" Inherits="Social_media" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <form runat="server" id="form1">
        <div id="page-wrapper">
            <div class="main-page">
                <div class="forms validation">


                    <div class="row">
                        <div class="col-md-4" data-example-id="basic-forms">
                            <div class="form-title">
                                <h4>Add Social Media </h4>
                            </div>
                            <div class="form-body">
                                <form data-toggle="validator">

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
                                        <asp:TextBox runat="server" ID="txt_youtube" CssClass="form-control" Placeholder="Youtube Link" required="required" />
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_dribble" CssClass="form-control" Placeholder="Dribble Link " required="required" />
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="txt_personal_link" CssClass="form-control" Placeholder="Your Personal Link" required="required" />
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
                                <h4>View Social </h4>
                            </div>

                            <div class="card card-contact-list">
                                <div class="agileinfo-cdr">

                                    <div class="card-body p-b-20">
                                        <div class="list-group">
                                            <asp:ListView runat="server" ID="lv_show_social">
                                                <ItemTemplate>
                                                    <a class="list-group-item media" href="#">

                                                        <div class="media-body">
                                                            <div class="pull-left">
                                                                <div class="lg-item-heading"><%# Eval("facebook") %></div>
                                                            </div>

                                                        </div>
                                                    </a>

                                                    <a class="list-group-item media" href="#">

                                                        <div class="media-body">
                                                            <div class="pull-left">
                                                                <div class="lg-item-heading"><%# Eval("twitter") %></div>
                                                            </div>

                                                        </div>
                                                    </a>

                                                    <a class="list-group-item media" href="#">

                                                        <div class="media-body">
                                                            <div class="pull-left">
                                                                <div class="lg-item-heading"><%# Eval("linkdin") %></div>
                                                            </div>

                                                        </div>
                                                    </a>

                                                    <a class="list-group-item media" href="#">

                                                        <div class="media-body">
                                                            <div class="pull-left">
                                                                <div class="lg-item-heading"><%# Eval("googleplus") %></div>
                                                            </div>

                                                        </div>
                                                    </a>

                                                    <a class="list-group-item media" href="#">

                                                        <div class="media-body">
                                                            <div class="pull-left">
                                                                <div class="lg-item-heading"><%# Eval("instagram") %></div>
                                                            </div>

                                                        </div>
                                                        <a class="list-group-item media" href="#">

                                                            <div class="media-body">
                                                                <div class="pull-left">
                                                                    <div class="lg-item-heading"><%# Eval("pinterest") %></div>
                                                                </div>

                                                            </div>

                                                            <a class="list-group-item media" href="#">

                                                                <div class="media-body">
                                                                    <div class="pull-left">
                                                                        <div class="lg-item-heading"><%# Eval("youtube") %></div>
                                                                    </div>

                                                                </div>
                                                            </a>

                                                            <a class="list-group-item media" href="#">

                                                                <div class="media-body">
                                                                    <div class="pull-left">
                                                                        <div class="lg-item-heading"><%# Eval("dribble") %></div>
                                                                    </div>

                                                                </div>
                                                            </a>

                                                            <a class="list-group-item media" href="#">

                                                                <div class="media-body">
                                                                    <div class="pull-left">
                                                                        <div class="lg-item-heading"><%# Eval("personal_link") %></div>
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
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
        </div>

    </form>

</asp:Content>

