<%@ Page Title="SessionState2" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SessionState2.aspx.cs" Inherits="SessionState.SessionState2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SessionState2</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>       
    </div>

</asp:Content>
