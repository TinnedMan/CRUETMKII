using system;

protected void Page_Load(object sender, EventArgs e)

{
double startCounter = Convert.ToDouble(DateTime.Now.TimeOfDay.TotalSeconds); if (!IsPostBack)

{

griddatabind(0);
ViewState["currentIndex"] = 0;

 

//DropDownList ddlPages = (DropDownList)UpdatePanel1.FindControl("ddlPages");

//for (int i = 1; i <= Convert.ToInt32(ViewState["numberOfPages"]); i++)

//{

// ddlPages.Items.Add(i.ToString());

//}

}
double endCounter = Convert.ToDouble(DateTime.Now.TimeOfDay.TotalSeconds);double totalSeconds = endCounter - startCounter;

Response.Write(totalSeconds);

}
