using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace Web_Browser
{
    //code for the form class that handles everything that manipulates the form in some way
    public partial class WebBrowser : Form
    {
        //global value that holds the URL of the current homepage, defaults to https://www.google.com
        static string homepage = "https://www.google.com";
        //uses my own class to make a doubly linked list called history which start with its first element being homepage, this
        //will be used in the implementation of the back and forward butoons
        LinkedHistoryList history = new LinkedHistoryList(new LinkedHistoryNode(homepage));

        //constructor
        public WebBrowser()
        {
            InitializeComponent();
            //so that the Form1_Load method is called
            Load += new EventHandler(Form1_Load);
        }

        //method called when web browser starts up
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //takes the favourites stored from previous sessions and loads them to the favourites data grid
                XmlDocument favInput = new XmlDocument();
                favInput.Load("Favourites.xml");
                for (int i = 1; i < (favInput.DocumentElement.ChildNodes.Count/2) + 1; i++)
                {
                    //the favouritesDataGrid is what displays the favourites
                    favouritesDataGrid.Rows.Add(favInput.DocumentElement.SelectSingleNode("/Favourites/Name[" + i + "]").InnerText, favInput.DocumentElement.SelectSingleNode("/Favourites/URL[" + i + "]").InnerText);
                }
            }
            //only need to catch this error, if there isnt any file then we dont need to add anything to the favourites data grid
            catch(FileNotFoundException ex)
            {

            }


            try
            {
                //loads in previously set homepage from previous session
                XmlDocument homeInput = new XmlDocument();
                homeInput.Load("Home.xml");
                homepage = homeInput.DocumentElement.SelectSingleNode("/Home").InnerText;
            }
            //only need to catch error, if there is no previous homepage then it will default to https://www.google.com
            catch (FileNotFoundException ex )
            {

            }

            try
            {
                //loads in previous history into the HistoryTree
                XmlDocument historyInput = new XmlDocument();
                historyInput.Load("History.xml");
                for (int i = 1; i < historyInput.DocumentElement.ChildNodes.Count+1; i++)
                {
                    //the HistoryTree is what displays the history
                    HistoryTree.Nodes.Add(historyInput.DocumentElement.SelectSingleNode("/History/HistoryElement[" + i + "]").InnerText);
                }
            }
            //only need to catch, if there is no file then there is no previous history meaning we dont need to load anythin in
            catch(FileNotFoundException ex)
            {

            }

            //displays the hompage on startup
            displayAll(homepage);
            //adds homepage to history
            HistoryTree.Nodes.Add(homepage);
        }

        //Method that displays the title, status code/description and html from a given URL
        private void displayAll(string url)

        {
            try
            {
                //make sure everything is set to null first as we append things latter
                HTMLDisplay.Text = null;
                StatusDisplay.Text = null;
                TitleText.Text = null;
                //using my own class start a URL request
                URLRequest request = new URLRequest();
                //using a library class: create a HttpwebResponse that uses my class to get a Httpresponse
                HttpWebResponse response = request.getHttpResponse(url);
                //puts the html of the response in a variable
                string html = request.getHTML(response);
                //display the html to the main window
                HTMLDisplay.Text += html;
                //get the status of the response and display it in the status display
                StatusDisplay.Text += request.getStatus(response);
                //get the title of the page and display it in the title text box
                TitleText.Text += request.getTitle(html);
                //close the response
                response.Close();

            }
            //incase there is a null referece catch it here
            catch (NullReferenceException ex)
            {

            }

        }

        //auto-gen method header for the when the button labbeled 'GO' is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //take the text in the search box and store it in a variable
            string url = URLTextBox.Text;
            //display the url in the search box
            displayAll(url);
            //insert this as a node in the history doubly linked list so we can navigate to it
            history.Insert(new LinkedHistoryNode(url));
            //display the url in the HistoryTree
            HistoryTree.Nodes.Add(url);
        }

        //auto-gen method header for when the Forward button is clicked
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            //if there is nothing in the list beyond the current node then do nothing
            if (history.curr.next == null)
                return;
            else
            {
                //display the url of the node we are going to
                displayAll(history.curr.next.GetData());
                //set the current node to the next node in the list
                history.curr = history.curr.next;
            }
        }

        //auto-gen method header for when the back button is clicked
        private void BackButton_Click(object sender, EventArgs e)
        {
            //if there is nothing in the list before the current node then do nothing
            if (history.curr.prev == null)
                return;
            else
            {
                //display the url of the previous node in the list
                displayAll(history.curr.prev.GetData());
                //set the current node to the previous node in the list
                history.curr = history.curr.prev;
            }
        }

        //auto-gen method header for when the history option in the menu strip is clicked
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle visibility of the history tree as it is always present but not always visible
            HistoryTree.Visible = !HistoryTree.Visible;

        }

        //auto-gen method header for when the 'Add' option in the 'Favourites' drop down list is clicked
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the potential url of a new favourite to the current page url
            favouriteURL.Text = history.curr.GetData();
        }


        ////auto-gen method header for when an item in the HistoryTree is clicked
        private void HistoryTree_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            //display the web page of the url selected int the HistoryTree
            string url = HistoryTree.SelectedNode.Text;
            displayAll(url);
        }

        //auto-gen method header for when for when the 'Go Home' option in the 'Home' drop down menu is clicked
        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display web page of the current homepage
            displayAll(homepage);
            //add this to the history doubly-linked list so we can navigate to it
            history.Insert(new LinkedHistoryNode(homepage));
            //display the hompage URL in the HistoryTree
            HistoryTree.Nodes.Add(homepage);
        }

        //auto-gen method header for when the confirm option is clicked when adding a new favourite
        private void confirmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //display the URL and associated Name given by the user in the favourites Data Grid
            favouritesDataGrid.Rows.Add(favouriteName.Text, favouriteURL.Text);
        }

        //auto-gen method header for when a row in the favouritesDataGrid is clicked
        private void favouritesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //display the web page of the url of the row that is clicked in the favouritesDataGrid
            string url = favouritesDataGrid[1, e.RowIndex].Value.ToString();
            displayAll(url);
            //add this to the history doubly-linked list so we can navigate to it
            history.Insert(new LinkedHistoryNode(homepage));
            //display the hompage URL in the HistoryTree
            HistoryTree.Nodes.Add(homepage);

        }

        //auto-gen method header for when the confirm option is clicked when changing homepage
        private void confirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change the homepage to the url given by the user
            homepage = HomeChangeText.Text;
        }


        //auto-gen method header for when the 'Change Home' option is clicked in the drop down menu of 'Home'
        private void changeHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //setthe potential url of the new homepage to that of the current webpage url
            HomeChangeText.Text = history.curr.GetData();
        }


        //auto-gen method header for when the 'Delete' option id clicked on a selected favouritesDataGrid Row
        private void deleteFavourites_Click(object sender, EventArgs e)
        {
            //delets the row selected by the user
            foreach (DataGridViewCell Cell in favouritesDataGrid.SelectedCells)
            {
                try
                {
                    if (Cell.Selected)
                        favouritesDataGrid.Rows.RemoveAt(Cell.RowIndex);
                }

                catch (InvalidOperationException)
                {

                }
            }
        }


        //auto-gen method header to execute code when the form closes
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //output all names and URLs of favourites to an XML file so that we may load it in next session
            XmlWriter favoutput = XmlWriter.Create("Favourites.xml");
            favoutput.WriteStartDocument();
            favoutput.WriteStartElement("Favourites");
            for (int i = 0; i < favouritesDataGrid.RowCount - 1; i++)
            {
                favoutput.WriteStartElement("Name");
                favoutput.WriteString(favouritesDataGrid[0, i].Value.ToString());
                favoutput.WriteEndElement();
                favoutput.WriteStartElement("URL");
                favoutput.WriteString(favouritesDataGrid[1, i].Value.ToString());
                favoutput.WriteEndElement();
            }

            favoutput.WriteEndElement();
            favoutput.WriteEndDocument();
            favoutput.Close();

            //output hompepage URL to a XML file so we can load it in next session
            XmlWriter homeOutput = XmlWriter.Create("Home.xml");
            homeOutput.WriteStartDocument();
            homeOutput.WriteStartElement("Home");
            homeOutput.WriteString(homepage);
            homeOutput.WriteEndElement();
            homeOutput.WriteEndDocument();
            homeOutput.Close();

            //output the history of the current sesion to an XML so that we can load it into the history of next sesion
            XmlWriter historyOutput = XmlWriter.Create("History.xml");
            historyOutput.WriteStartDocument();
            historyOutput.WriteStartElement("History");
            for (int i = 0; i < HistoryTree.Nodes.Count; i++)
            {
                historyOutput.WriteStartElement("HistoryElement");
                historyOutput.WriteString(HistoryTree.Nodes[i].Text);
                historyOutput.WriteEndElement();
            }


            historyOutput.WriteEndElement();
            historyOutput.WriteEndDocument();
            historyOutput.Close();

        }
        //auto gen method header for when the 'Refresh' Button is clicked
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //Displays the web page of the current page by sending another HTTP request
            displayAll(history.curr.GetData());
        }
    }


    //Class that deals with  node level operations
    public class LinkedHistoryNode
    {
        //data that contains the value related to the node
        private string data;
        //store a link to the previous node
        public LinkedHistoryNode prev;
        //store a link to the next node
        public LinkedHistoryNode next;


        //Constructor
        public LinkedHistoryNode(string root)
         {
            //initialise the data to the value provided
            this.data = root;
            //initialise the previous link to null
            this.prev = null;
            //initialise the next link to null
            this.next = null;
        }


        //public method to get the value of the private data string
        public string GetData()
        {
            //return value of the node
            return this.data;
        }

    }


    //Class to deal with the List level operations
    public class LinkedHistoryList
    {
        //keeps track of the current node in the list
        public LinkedHistoryNode curr;

        //constructor
        public LinkedHistoryList(LinkedHistoryNode Init)
        {
            //initialises the current node to the value provided
            curr = Init;
        }

        //inserts a node into the list
        public void Insert(LinkedHistoryNode node)
        {
            //compares to see if the node being added has the same value as the current node, if it does then do nothing
            if (string.Compare(curr.GetData(), node.GetData()).Equals(true))
            {

                return;
            }
            else
            {
                //set the link to the previous node of the added node to the current node
                node.prev = curr;
                //set the link to the next node of the current node to the node being added
                curr.next = node;
                //set the link to the next node of the node being added to null, this is important to keep the back and forward buttons
                //functioning like other browsers and only showing the
                node.next = null;
                //set the current node to be the node that has been added
                curr = node;
            }
        }

    }
}


//class to deal with any http requests from URL
public class URLRequest
{
    //returns the HTML code given from the response
    public string getHTML(HttpWebResponse response)
    {
        try
        {
            //start a stream from the response provided
            Stream dataStream = response.GetResponseStream();
            //create a reader from the above stream
            StreamReader reader = new StreamReader(dataStream);
            //read to end using this streamreader and store the output
            string httpOutput = reader.ReadToEnd();
            //close up all the streams
            reader.Close();
            dataStream.Close();
            response.Close();
            //output the html read from the response
            return httpOutput;
        }
        catch (NullReferenceException ex)
        {
            //if there was an error then return the exception instead
            return "Please check To see if the URL is correct";
        }

    }

    //returns the Status description and Code from the response
    public string getStatus(HttpWebResponse response)
    {
        try
        {
            //store the status description from the response
            string statusDes = response.StatusDescription;
            //store the status code from the reponse
            HttpStatusCode statusCode = response.StatusCode;
            //return the concatenation of the status descriptoin and the status code with a space in the middle
            return statusDes + " " + (int)statusCode;
        }
        catch (NullReferenceException ex)
        {
            //if there is an error , return the exception message instead
            return ex.ToString();
        }
    }

    //returns the response from a URL
    public HttpWebResponse getHttpResponse(string url)
    {
        try
        {
            //create a new request
            WebRequest request = WebRequest.Create(url);
            //get a response from the request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //return this response
            return response;
        }
        catch (WebException ex)

        {
            //even if there is an error return the response of the exception
            return (HttpWebResponse)ex.Response;

        }
        //catch an excpetion where thers is a formatting error
        catch (UriFormatException ex)
        {

            //if there is a format error, return null to the call as it will be handled there
            return null;
        }
    }

   //returns the title of a page from a Block of HTML code
    public string getTitle(string htmlinput)
    {
        //uses regexs to search through the html code and output the title
        return Regex.Match(htmlinput, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;
    }
}
