using SwissTransport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Intelisense
{
    Transport transport = new Transport();
    public void AutoCompletion(ComboBox sender)
    {
        while (sender.Items.Count > 0)
        {
            sender.Items.RemoveAt(0);
        }

        //set Cursor Wait
        Cursor.Current = Cursors.WaitCursor;

        List<string> stations = GetSuggestions(sender.Text);

        //reset Cursor
        Cursor.Current = Cursors.WaitCursor;

        foreach (String station in stations)
        {
            if (station != null)
            {
                sender.Items.Add(station);
            }
        }
        sender.DroppedDown = true;
    }

    private List<string> GetSuggestions(string query)
    {
        List<string> stationsList = new List<string>();
        //get all stations with matching string
        var stations = transport.GetStations(query);

        foreach (Station station in stations.StationList)
        {
            //adding stations to combobox
            stationsList.Add(station.Name);
        }
        if (stationsList.Count == 0)
        {
            //if Input not valid
            stationsList.Add("Kein Resultat");
        }
        //return stationlist 
        return stationsList;
    }
}
