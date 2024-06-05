<%@ Page Language="C#" %>
<%@ Import Namespace="System.Web.Security" %>
<%@ Import Namespace="System.Collections.Specialized" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

public void Page_Load(object sender, EventArgs args)
{
  Snippet1();
  Snippet2();
  Snippet3();
}

public void Snippet1()
{
//<Snippet1>
// Identify the connection string for the SqlMembershipProvider.
NameValueCollection config = new NameValueCollection();
config.Add("connectionStringName", "SqlServices");

// Create and Initialize the SqlMembershipProvider.
SqlMembershipProvider p = new SqlMembershipProvider();
p.Initialize("MySqlProvider", config);

// Create the MembershipProviderCollection and add the SqlMembershipProvider.
MembershipProviderCollection coll = new MembershipProviderCollection();
coll.Add(p);
//</Snippet1>

  ProvidersListBox.DataSource = coll;
  ProvidersListBox.DataBind();
}

public void Snippet2()
{
//<Snippet2>
SqlMembershipProvider p = (SqlMembershipProvider)Membership.Providers["SqlProvider"];
PasswordFormatLabel.Text = p.PasswordFormat.ToString();
//</Snippet2>
}

public void Snippet3()
{
//<Snippet3>
MembershipProviderCollection providers = Membership.Providers;
MembershipProvider[] copiedProviders = new MembershipProvider[providers.Count];
providers.CopyTo(copiedProviders, 0);
//</Snippet3>
}

</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<title>Sample: Provider List</title>
</head>
<body>

<form id="form1" runat="server">
  <h3>Provider List</h3>

      <asp:ListBox id="ProvidersListBox" DataTextField="Name" 
                   Rows="8" runat="server" />

      <asp:Label id="PasswordFormatLabel" runat="server" />
</form>

</body>
</html>
