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

/* 

Put int startCounter= DateTime.Now.TimeOfDay.TotalSeconds; as a first statement
in the page_load in order to to get the TotalSeconds when this application has been loaded

and at the end of the page load add int endCounter = DateTime.Now.TimeOfDay.TotalSeconds;

now add int totalSeconds = endCounter - startCounter; //which will get the time needed to run this event.

Response.Write(totalSeconds);

Just like this...

*/
