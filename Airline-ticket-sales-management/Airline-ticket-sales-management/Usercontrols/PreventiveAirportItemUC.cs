using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class PreventiveAirportItemUC : UserControl
    {
        private int _stt;
        public int stt
        {
            get { return _stt; }
            set
            { 
                _stt = value;
                lbStt.Text = stt.ToString();
            }
        }

        private PreventiveAirportDTO _preventiveAirport;
        public PreventiveAirportDTO PreventiveAirport
        {
            get { return _preventiveAirport; }
            set
            {
                _preventiveAirport = value;

                atxbPlane.Texts = PreventiveAirport.AirportName + " (" + PreventiveAirport.CityName + ")";
                atxbStopoverDuration.Texts = PreventiveAirport.StopoverDuration.ToString();
                atxbNote.Texts = PreventiveAirport.Note;
            }
        }

        public PreventiveAirportItemUC()
        {
            InitializeComponent();

            atxbNote.isPlaceholder = false;
            atxbNote.setForeColor();

            atxbPlane.isPlaceholder = false;
            atxbPlane.setForeColor();

            atxbStopoverDuration.isPlaceholder = false;
            atxbStopoverDuration.setForeColor();

            atxbStopoverDuration.Texts = ParametersDTO.Ins.MinimumStopoverTime.ToString();
        }

        public void setCompletePlaneID(List<string> keys)
        {
            this.atxbPlane.complete(keys);
        }

        private void atxbStopoverDuration__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(atxbStopoverDuration.Texts.Trim()))
            {
                int value = int.Parse(atxbStopoverDuration.Texts.Trim());

                if (value < ParametersDTO.Ins.MinimumStopoverTime)
                    atxbStopoverDuration.Texts = ParametersDTO.Ins.MinimumStopoverTime.ToString();

                if (value > ParametersDTO.Ins.MaximumStopoverTime)
                    atxbStopoverDuration.Texts = ParametersDTO.Ins.MaximumStopoverTime.ToString();
            }
        }

        public async Task<PreventiveAirportDTO> getPreventiveAirport()
        {
            PreventiveAirportDTO preventiveAirportDTO = new PreventiveAirportDTO();
            (AirportDTO airport, string label) = await AirportDAL.Ins.findAirport(atxbPlane.Texts.Trim());
            if (airport == null)
                return null;
            else
                preventiveAirportDTO.PreventiveAirportID = airport.AirportID;
            
            preventiveAirportDTO.StopoverDuration = int.Parse(atxbStopoverDuration.Texts.Trim());
            preventiveAirportDTO.Note = atxbNote.Texts.Trim();

            return preventiveAirportDTO;
        }
    }
}
