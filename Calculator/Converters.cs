// Finished

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Converters : Form
    {
        // List init
        private readonly List<string> massUnits = new List<string>()
        {
            "Grams (g)",
            "Pounds (lb)",

        };
        private readonly List<string> velocityUnits = new List<string>()
        {
            "Miles per hour (mph)",
            "Kilometers per hour (km/h)",
            "Meters per second (m/s)"
        };
        private readonly List<string> temperatureUnits = new List<string>()
        {
            "Celsius (°C)",
            "Fahrenheit (°F)",
            "Kelvin (K)"
        };
        private readonly List<string> areaUnits = new List<string>() 
        {
            "Square meters (m²)",
            "Square feet (ft²)"
        };
        private readonly List<string> lengthUnits = new List<string>()
        {
            "Meters (m)",
            "Feet (ft)"
        };
        private readonly List<string> volumeUnits = new List<string>()
        {
            "Cubic meters (m³)",
            "Cubic feet (m³)"
        };
        private readonly List<string> timeUnits = new List<string>()
        {
            "Seconds (s)",
            "Minutes (min)",
            "Hours (h)"
        };
        private readonly List<string> dataUnits = new List<string>()
        {
            "Kilobytes (KB)",
            "Megabytes (MB)",
            "Gigabytes (GB)"
        };

        // Variable init
        public double conversion;
        public float inputNum;
        public Converters()
        {
            InitializeComponent();

            // Event init
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Click += new EventHandler(this.OnButtonClick);
                }
            }
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Name)
            {
                case "mass":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(massUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(massUnits.ToArray());
                    break;
                case "velocity":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(velocityUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(velocityUnits.ToArray());
                    break;
                case "temperature":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(temperatureUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(temperatureUnits.ToArray());
                    break;
                case "area":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(areaUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(areaUnits.ToArray());
                    break;
                case "length":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(lengthUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(lengthUnits.ToArray());
                    break;
                case "volume":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(volumeUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(volumeUnits.ToArray());
                    break;
                case "time":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(timeUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(timeUnits.ToArray());
                    break;
                case "data":
                    input.Text = 0.ToString();
                    output.Text = 0.ToString();

                    inputList.Text = "Select input unit";
                    outputList.Text = "Select output unit";

                    inputList.Items.Clear();
                    inputList.Items.AddRange(dataUnits.ToArray());

                    outputList.Items.Clear();
                    outputList.Items.AddRange(dataUnits.ToArray());
                    break;
                case "conv":
                    if ((inputList.Items.Count == 0 && outputList.Items.Count == 0) || (inputList.SelectedItem == null || outputList.SelectedItem == null))
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            inputNum = float.Parse(input.Text);
                        }
                        catch
                        {
                            output.Text = "Invalid input.";
                            break;
                        }
                        string inputUnit = inputList.SelectedItem.ToString();
                        string outputUnit = outputList.SelectedItem.ToString();
                        string Units = inputUnit + " | " + outputUnit;
                        switch (Units)
                        {
                            // Mass combinations
                            case "Grams (g) | Pounds (lb)":
                                conversion = inputNum / 453.592;
                                output.Text = conversion.ToString();
                                break;
                            case "Pounds (lb) | Grams (g)":
                                conversion = inputNum * 453.592;
                                output.Text = conversion.ToString();
                                break;
                            // Velocity combinations
                            case "Miles per hour (mph) | Kilometers per hour (km/h)":
                                conversion = inputNum * 1.609344;
                                output.Text = conversion.ToString();
                                break;
                            case "Miles per hour (mph) | Meters per second (m/s)":
                                conversion = inputNum * 0.44704;
                                output.Text = conversion.ToString();
                                break;
                            case "Kilometers per hour (km/h) | Miles per hour (mph)":
                                conversion = inputNum * 0.6213711922;
                                output.Text = conversion.ToString();
                                break;
                            case "Kilometers per hour (km/h) | Meters per second (m/s)":
                                conversion = inputNum * 0.2777777778;
                                output.Text = conversion.ToString();
                                break;
                            case "Meters per second (m/s) | Kilometers per hour (km/h)":
                                conversion = inputNum * 3.6;
                                output.Text = conversion.ToString();
                                break;
                            case "Meters per second (m/s) | Miles per hour (mph)":
                                conversion = inputNum * 2.2369392921;
                                output.Text = conversion.ToString();
                                break;
                            // Area combinations
                            case "Square meters (m²) | Square feet (ft²)":
                                conversion = inputNum * 10.76364864;
                                output.Text = conversion.ToString();
                                break;
                            case "Square feet (ft²) | Square meters (m²)":
                                conversion = inputNum * 0.09290304;
                                output.Text = conversion.ToString();
                                break;
                            // Length combinations
                            case "Meters (m) | Feet (ft)":
                                conversion = inputNum * 3.280839895;
                                output.Text = conversion.ToString();
                                break;
                            case "Feet (ft) | Meters (m)":
                                conversion = inputNum * 0.3048;
                                output.Text = conversion.ToString();
                                break;
                            // Temperature combinations
                            case "Celsius (°C) | Fahrenheit (°F)":
                                conversion = (inputNum * 9 / 5) + 32;
                                output.Text = conversion.ToString();
                                break;
                            case "Celsius (°C) | Kelvin (K)":
                                conversion = inputNum + 273.15;
                                output.Text = conversion.ToString();
                                break;
                            case "Fahrenheit (°F) | Celsius (°C)":
                                conversion = (inputNum - 32) * 5 / 9;
                                output.Text = conversion.ToString();
                                break;
                            case "Fahrenheit (°F) | Kelvin (K)":
                                conversion = ((inputNum - 32) * 5 / 9) + 273.15;
                                output.Text = conversion.ToString();
                                break;
                            case "Kelvin (K) | Celsius (°C)":
                                conversion = inputNum - 273.15;
                                output.Text = conversion.ToString();
                                break;
                            case "Kelvin (K) | Fahrenheit (°F)":
                                conversion = (inputNum - 273.15) * 9 / 5 + 32;
                                output.Text = conversion.ToString();
                                break;
                            // Volume combinations
                            case "Cubic meters (m³) | Cubic feet (ft³)":
                                conversion = inputNum * 35.31467;
                                output.Text = conversion.ToString();
                                break;
                            case "Cubic feet (ft³) | Cubic meters (m³)":
                                conversion = inputNum * 0.028316846592;
                                output.Text = conversion.ToString();
                                break;
                            // Time combinations
                            case "Seconds (s) | Minutes (min)":
                            case "Minutes (min) | Hours (h)":
                                conversion = inputNum * 0.01;
                                output.Text = conversion.ToString();
                                break;
                            case "Seconds (s) | Hours (h)":
                                conversion = inputNum * 0.000278;
                                output.Text = conversion.ToString();
                                break;
                            case "Minutes (min) | Seconds (s)":
                            case "Hours (h) | Minutes (min)":
                                conversion = inputNum * 60;
                                output.Text = conversion.ToString();
                                break;
                            case "Hours (h) | Seconds (s)":
                                conversion = inputNum * 3600;
                                output.Text = conversion.ToString();
                                break;
                            // Data combinations
                            case "Kilobytes (KB) | Megabytes (MB)":
                            case "Megabytes (MB) | Gigabytes (GB)":
                                conversion = inputNum * 0.001;
                                output.Text = conversion.ToString();
                                break;
                            case "Kilobytes (KB) | Gigabytes (GB)":
                                conversion = inputNum * 0.000001;
                                output.Text = conversion.ToString();
                                break;
                            case "Megabytes (MB) | Kilobytes (KB)":
                            case "Gigabytes (GB) | Megabytes (MB)":
                                conversion = inputNum * 1000;
                                output.Text = conversion.ToString();
                                break;
                            case "Gigabytes (GB) | Kilobytes (GB)":
                                conversion = inputNum * 1000000;
                                output.Text = conversion.ToString();
                                break;
                            // In case the input unit is the same as the output unit
                            default:
                                output.Text = input.Text;
                                break;
                        }
                        break;
                    }
            }
        }
    }
}