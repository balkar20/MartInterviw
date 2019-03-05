<%@ Page Language="C#" %>
<%@ Import Namespace="Client1.Summator" %>
<%@ Import Namespace="Client1.CarService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    CarServiceClient _client = new CarServiceClient("BasicHttpBinding_ICarService");

    protected void btnGetCar_Click(object sender, EventArgs e)
    {
        var id = int.Parse(txtId.Text);

        var car = _client.GetCar(id);
        txtId.Text = car.Id.ToString();
        txtVender.Text = car.Vendor;
        txtModel.Text = car.Model;
        txtYear.Text = car.Year.ToString();
    }

    protected void btnSetCar_Click(object sender, EventArgs e)
    {
        var id = int.Parse(txtId.Text);
        var ven = txtVender.Text;
        var mod = txtModel.Text;
        var year = int.Parse(txtYear.Text);

        _client.SrtCar(new Car(){Id=id, Vendor = ven, Model = mod, Year = year});
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        <asp:Label runat="server">Id</asp:Label>
        <asp:TextBox runat="server" ID="txtId"></asp:TextBox>
        <asp:Label runat="server">Vander</asp:Label>
        <asp:TextBox runat="server" ID="txtVender"></asp:TextBox>
        <asp:Label runat="server">Model</asp:Label>
        <asp:TextBox runat="server" ID="txtModel"></asp:TextBox>
        
        <asp:Label runat="server">Year</asp:Label>
     <asp:TextBox runat="server" ID="txtYear"></asp:TextBox>
        <asp:Button runat="server" ID="btnGetCar" Text="Get" OnClick="btnGetCar_Click"/>
        <asp:Button runat="server" ID="btnSetCar" Text="Set" OnClick="btnSetCar_Click"/>
    </div>
    
    
</form>
</body>
</html>
