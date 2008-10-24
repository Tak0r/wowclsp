/*
    WoW Combatlog Splitter
    Copyright (C) 2008 Frank Gehann (Takoura EU-Perenolde)
	
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Net;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;



namespace WoW_Combatlog_Splitter
{
    public partial class WoWCombatlogSplitter : Form
    {
        bool abort = false;

        public WoWCombatlogSplitter()
        {
            InitializeComponent();
        }

        private void btn_combatlog_Click(object sender, EventArgs e)
        {
            dlg_combatlog.ShowDialog();
        }

        private void btn_parse_Click(object sender, EventArgs e)
        {
            // Check if Dateformat is Valid!
            Regex date_format = new Regex("^[MdyHhmst_.\\s-]*$", RegexOptions.Singleline);
            Match md = date_format.Match(edt_dateformat.Text);

            // Check if Splittime is Valid!
            Regex split_time_format = new Regex("^[\\d]{1,5}$", RegexOptions.Singleline);
            Match st = split_time_format.Match(edt_splittime.Text);

            if (md.Success && st.Success)
            { // everything seems to be ok so faar we'll see =)

                btn_parse.Visible = false;
                btn_parse.Enabled = false;
                btn_abort.Visible = true;
                btn_abort.Enabled = true;
                btn_combatlog.Enabled = false;

                // create variables
                string file = dlg_combatlog.FileName;
                string path = Path.GetDirectoryName(file);
                string line = string.Empty;
                string writelog = string.Empty;
                string newlogname = string.Empty;
                string oldlogname = string.Empty;
                string logname = string.Empty;

                // Regex for matching a date!
                // Format: 6/8 14:58:33.943
                // or
                // Format: 10/18 14:58:33.943
                Regex date_match = new Regex("^(?<months>[0-9]{1,2})/(?<days>[0-9]{1,2}) (?<hours>[0-9]{2}):(?<minutes>[0-9]{2}):(?<seconds>[0-9]{2}).(?<milliseconds>[0-9]{3})  .*$");

                DateTime lastdate = new DateTime(2000, 1, 1); // set fake lastdate since we need some match for the first line!
                DateTime currdate = DateTime.Now; // set current date for a match at the first line!
                TimeSpan timediff;

                long line_count = 0;
                int diff_logs = 0;

                Stopwatch parsetime = new Stopwatch();

                // create the filestream objects
                FileStream fs_olog = new FileStream(file, FileMode.Open, FileAccess.Read);
                FileStream fs_nlog = null;
                // create the streamreader objects
                StreamReader sr_olog = new StreamReader(fs_olog);
                StreamWriter sw_nlog = null;

                // max progressbar length and make it visible!
                prg_parse.Maximum = (int)fs_olog.Length;
                prg_parse.Visible = true;

                // start the stopwatch for the logcreating process
                parsetime.Start();

                while (!abort && (line = sr_olog.ReadLine()) != null)
                {
                    // get the current linedate by matching via regular expressions
                    Match line_match = date_match.Match(line);
                    GroupCollection group_match = line_match.Groups;

                    // set the parsed linedate into a time object
                    DateTime linedate = new DateTime(
                                        currdate.Year,  // Jahr fake it to the current year... common bliss was it too much to include it too?
                                        Convert.ToInt32(group_match["months"].Value), // month
                                        Convert.ToInt32(group_match["days"].Value), // day
                                        Convert.ToInt32(group_match["hours"].Value), // hour
                                        Convert.ToInt32(group_match["minutes"].Value), // minute
                                        Convert.ToInt32(group_match["seconds"].Value) // second
                                        );

                    // get the difference between the last and the current line
                    timediff = linedate - lastdate;

                    // apply the date of the last line
                    lastdate = linedate;

                    // if the timeframe between 2 lines is greater than 2 hours or
                    // we are at the first line, create a new logfile
                    if (Convert.ToInt32(timediff.TotalSeconds) > Convert.ToInt32(edt_splittime.Text) || line_count == 0)
                    {

                        logname = "WoWCombatLog_" + String.Format("{0:" + edt_dateformat.Text + "}", lastdate) + ".txt";

                        newlogname = path + "\\" + logname;


                        lbl_combatlog.Text = logname;
                        diff_logs++;

                        if (oldlogname != newlogname && !string.IsNullOrEmpty(oldlogname))
                        {
                            sw_nlog.Close();
                            fs_nlog.Close();

                            // here comes some ziping algorithm later i think O.o!! (Todo)

                        }

                        // try to open a new file to write in!
                        // if the file exists delete it and create a new one!
                        try
                        {
                            if (File.Exists(newlogname))
                            {
                                try
                                {
                                    File.Delete(newlogname);
                                }
                                catch (Exception ex)
                                {
                                    lbl_combatlog.Text = "could not delete file " + Path.GetFileName(newlogname);
                                    // Progressbar resetten
                                    prg_parse.Value = 0;
                                    parsetime.Stop();
                                    return;
                                }
                            }
                            fs_nlog = new FileStream(newlogname, FileMode.CreateNew, FileAccess.Write);
                            sw_nlog = new StreamWriter(fs_nlog);
                        }
                        catch (Exception ex)
                        {
                            // throw an error and provide the filename where the error occured
                            lbl_combatlog.Text = "Cannot open " + Path.GetFileName(newlogname);
                            // Progressbar resetten
                            prg_parse.Value = 0;
                            parsetime.Stop();
                            return;
                        }

                        // safe current logname to equate it later
                        oldlogname = newlogname;
                    }

                    // write current line to the log
                    sw_nlog.WriteLine(line);

                    line_count++;

                    // fill the progressbar
                    prg_parse.Value = (int)sr_olog.BaseStream.Position;

                    // refresh application form
                    Application.DoEvents();
                } // while

                // close file hadlers
                // Read
                sr_olog.Close();
                fs_olog.Close();
                // Read
                sw_nlog.Close();
                fs_nlog.Close();


                // resetten the progressbar since we finished
                prg_parse.Value = 0;

                parsetime.Stop();

                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = parsetime.Elapsed;

                lbl_combatlog.Text = String.Format("Parse time: {0:00}:{1:00}.{2:00} | logs: {3} | lines : {4}",
                                                    ts.Hours,
                                                    ts.Minutes,
                                                    ts.Seconds,
                                                    diff_logs,
                                                    line_count
                                                    );

                // hide buttons/progressbar
                prg_parse.Visible = false;
                btn_abort.Visible = false;
            }
            else
            {
                if(!md.Success)
                    MessageBox.Show("Date time format is not correct. Please try again!");
                if(!st.Success)
                    MessageBox.Show("Split time Format is not correct. Please try again!");
            }
        }

        private void dlg_combatlog_FileOk(object sender, CancelEventArgs e)
        {
            btn_parse.Visible = true;
            btn_parse.Enabled = true;
            abort = false; // reset the abort var mabe it has been abortet before?
            lbl_combatlog.Text = dlg_combatlog.FileName;
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            // set abort flag
            abort = true;
            
            // hide & deactivate abort button
            btn_abort.Visible = false;
            btn_abort.Enabled = false;
            
            // show parse button but deactivate it for now (the log has to be needs to be loaded again!)
            btn_parse.Visible = true;
            btn_parse.Enabled = false;

            // activate combatlog button
            btn_combatlog.Enabled = true;
        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_link.Links[lbl_link.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(lbl_link.Text);
        }

    }
}
