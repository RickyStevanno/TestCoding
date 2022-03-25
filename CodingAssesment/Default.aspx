<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CodingAssesment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="" BackColor="Red"></asp:Label>
        <br />
        
        <h5>Upload The File Here!</h5>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="btnSort" runat="server" Text="Sort" BackColor="LightBlue" Width="100px" OnClick="btnSort_Click" />
        </p>
       
    </div>
    <div>
         <h5>Click the Sort button and The Result will show Below!</h5>
        <asp:GridView ID="gridResult" runat="server" CellPadding="100"></asp:GridView>
        <h5>File will created at D:\\sorted-names-list.txt</h5>
    </div>

    

</asp:Content>
