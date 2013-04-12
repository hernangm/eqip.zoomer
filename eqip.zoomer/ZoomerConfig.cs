using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eqip.zoomer
{
    public class ZoomerConfig
    {
        string yes = "yes";
        string no = "no";

        public enum ScrollbarOrientations
        {
            Horizontal,
            Vertical
        }

        public enum MarkerZoomRegistrationPoints
        {
            bottom,
            bottomCenter
        }

        //<summary>component_width</summary>
        //<value>the plugin width in pixels</value>
        public int component_width { get; set; }

        //<summary>component_height</summary>
        //<value>the plugin height in pixels</value>
        public int component_height { get; set; }

        //<summary>background_color</summary>
        //<value>the background color, if you leave this blank the background will be transparent</value>
        public string background_color { get; set; }

        //<summary>image_path</summary>
        //<value>the image path for desktop</value>
        public string image_path { get; set; }

        //<summary>mobile_image_path</summary>
        //<value>the image path for mobile</value>
        public string mobile_image_path { get; set; }

        //<summary>zoom_factor</summary>
        //<value>the zoom factor, this is how much the image will zoom from it's initial size after is loaded and resized the first time, this number can be float for example 1.5.</value>
        public float zoom_factor { get; set; }

        //<summary>zoom_speed</summary>
        //<value>the zoom zoom speed this is a float number starting from 0.</value>
        public float zoom_speed { get; set; }

        //<summary>move_speed</summary>
        //<value>the move speed when the navigation buttons are used, a integer number starting from 0.</value>
        public int move_speed { get; set; }

        //<summary>show_scroll_bar</summary>
        //<value>hides or shows the scrollbar</value>
        [XmlIgnore]
        public bool show_scroll_bar { get; set; }

        [XmlElement("show_scroll_bar"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_scroll_barString
        {
            get { return show_scroll_bar ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_scroll_bar = true;
                }
                else if (value == no)
                {
                    show_scroll_bar = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>scroll_bar_orientation</summary>
        //<value>the scrollbar orientation, it can be horizontal or vertical</value>
        public ScrollbarOrientations scroll_bar_orientation { get; set; }

        //<summary>scroll_bar_x</summary>
        //<value>the scrollbar x position in pixeles</value>
        public int scroll_bar_x { get; set; }

        //<summary>scroll_bar_y</summary>
        //<value>the scrollbar y position in pixeles</value>
        public int scroll_bar_y { get; set; }

        //<summary>scrollbar_handler_normal_state</summary>
        //<value>the scrollbar handler icon normal state.</value>
        public string scrollbar_handler_normal_state { get; set; }

        //<summary>scrollbar_handler_selected_state</summary>
        //<value>the scrollbar handler icon selected state.</value>
        public string scrollbar_handler_selected_state { get; set; }

        //<summary>scrollbar_track_normal_state</summary>
        //<value>the scrollbar track normal state.</value>
        public string scrollbar_track_normal_state { get; set; }

        //<summary>scrollbar_track_selected_state</summary>
        //<value>the scrollbar track selectedstate.</value>
        public string scrollbar_track_selected_state { get; set; }

        //<summary>show_buttons_background</summary>
        //<value>hides or shows the buttons background image</value>
        [XmlIgnore]
        public bool show_buttons_background { get; set; }

        [XmlElement("show_buttons_background"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_buttons_backgroundString
        {
            get { return show_buttons_background ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_buttons_background = true;
                }
                else if (value == no)
                {
                    show_buttons_background = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>buttons_background_x</summary>
        //<value>the x position in pixels for the buttons background.</value>
        public int buttons_background_x { get; set; }

        //<summary>buttons_background_y</summary>
        //<value>the y position in pixels for the buttons background.</value>
        public int buttons_background_y { get; set; }

        //<summary>buttons_background_icon</summary>
        //<value>the buttons background image path, this can be of type .png or .jpg.</value>
        public string buttons_background_icon { get; set; }

        //<summary>show_on_off_button</summary>
        //<value>hide or show the controller on/off button, when this buttons is pressed all other buttons, board, scrollbar are hidden and when pressed again are showed.</value>
        [XmlIgnore]
        public bool show_on_off_button { get; set; }

        [XmlElement("show_on_off_button"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_on_off_buttonString
        {
            get { return show_on_off_button ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_on_off_button = true;
                }
                else if (value == no)
                {
                    show_on_off_button = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>on_off_button_x</summary>
        //<value>the on/off button x position in pixels</value>
        public int on_off_button_x { get; set; }

        //<summary>on_off_button_y</summary>
        //<value>the on/off button y position in pixels.</value>
        public int on_off_button_y { get; set; }

        //<summary>on_off_button_x_when_hidden</summary>
        //<value>the on/off button x position in pixels when the button is pressed and the controls are hidden.</value>
        public int on_off_button_x_when_hidden { get; set; }

        //<summary>on_off_button_y_when_hidden</summary>
        //<value>the on/off button y position in pixels when the button is pressed and the controls are hidden.</value>
        public int on_off_button_y_when_hidden { get; set; }

        //<summary>on_off_button_normal_state</summary>
        //<value>the on/off button image icon normal state image path.</value>
        public string on_off_button_normal_state { get; set; }

        //<summary>on_off_button_selected_state</summary>
        //<value>the on/off button image icon selected state image path.</value>
        public string on_off_button_selected_state { get; set; }

        //<summary>show_maximum_size_button</summary>
        //<value>show or hides the maximum image size button, when this button is pressed the image will zoom in at its maximum size based on the zoom factor.</value>
        [XmlIgnore]
        public bool show_maximum_size_button { get; set; }

        [XmlElement("show_maximum_size_button"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_maximum_size_buttonString
        {
            get { return show_maximum_size_button ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_maximum_size_button = true;
                }
                else if (value == no)
                {
                    show_maximum_size_button = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>maximum_size_button_x</summary>
        //<value>the the maximum size button x position in pixels.</value>
        public int maximum_size_button_x { get; set; }

        //<summary>maximum_size_button_y</summary>
        //<value>the the maximum size button x position in pixels.</value>
        public int maximum_size_button_y { get; set; }

        //<summary>maximum_size_button_normal_state</summary>
        //<value>the maximum size button image icon normal state image path.</value>
        public string maximum_size_button_normal_state { get; set; }

        //<summary>maximum_size_button_selected_state</summary>
        //<value>the maximum size button image icon selected state image path.</value>
        public string maximum_size_button_selected_state { get; set; }

        //<summary>show_navigation_buttons</summary>
        //<value>show or hides the navigation buttons (up, down, right, left, reset) buttons.</value>
        [XmlIgnore]
        public bool show_navigation_buttons { get; set; }

        [XmlElement("show_navigation_buttons"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_navigation_buttonsString
        {
            get { return show_navigation_buttons ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_navigation_buttons = true;
                }
                else if (value == no)
                {
                    show_navigation_buttons = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>right_button_x</summary>
        //<value>the right button x position in pixels.</value>
        public int right_button_x { get; set; }

        //<summary>right_button_y</summary>
        //<value>the right button y position in pixels.</value>
        public int right_button_y { get; set; }

        //<summary>right_button_normal_state</summary>
        //<value>the right button image icon normal state image path.</value>
        public string right_button_normal_state { get; set; }

        //<summary>right_button_selected_state</summary>
        //<value>the right button image icon selected state image path.</value>
        public string right_button_selected_state { get; set; }

        //<summary>left_button_x</summary>
        //<value>the left button x position in pixels.</value>
        public int left_button_x { get; set; }

        //<summary>left_button_y</summary>
        //<value>the left button y position in pixels.</value>
        public int left_button_y { get; set; }

        //<summary>left_button_normal_state</summary>
        //<value>the left button image icon normal state image path.</value>
        public string left_button_normal_state { get; set; }

        //<summary>left_button_selected_state</summary>
        //<value>the left button image icon selected state image path.</value>
        public string left_button_selected_state { get; set; }

        //<summary>up_button_x</summary>
        //<value>the up button x position in pixels.</value>
        public int up_button_x { get; set; }

        //<summary>up_button_y</summary>
        //<value>the up button y position in pixels.</value>
        public int up_button_y { get; set; }

        //<summary>up_button_normal_state</summary>
        //<value>the up button image icon normal state image path.</value>
        public string up_button_normal_state { get; set; }

        //<summary>up_button_selected_state</summary>
        //<value>the up button image icon selected state image path.</value>
        public string up_button_selected_state { get; set; }

        //<summary>down_button_x</summary>
        //<value>the down button x position in pixels.</value>
        public int down_button_x { get; set; }

        //<summary>down_button_y</summary>
        //<value>the down button y position in pixels.</value>
        public int down_button_y { get; set; }

        //<summary>down_button_normal_state</summary>
        //<value>the down button image icon normal state image path.</value>
        public string down_button_normal_state { get; set; }

        //<summary>down_button_selected_state</summary>
        //<value>the down button image icon selected state image path.</value>
        public string down_button_selected_state { get; set; }

        //<summary>reset_button_x</summary>
        //<value>the reset button x position in pixels.</value>
        public int reset_button_x { get; set; }

        //<summary>reset_button_y</summary>
        //<value>the reset button y position in pixels.</value>
        public int reset_button_y { get; set; }

        //<summary>reset_button_normal_state</summary>
        //<value>the reset button image icon normal state image path.</value>
        public string reset_button_normal_state { get; set; }

        //<summary>reset_button_selected_state</summary>
        //<value>the reset button image icon selected state image path.</value>
        public string reset_button_selected_state { get; set; }

        //<summary>show_zoom_buttons</summary>
        //<value>show or hides the zoom in and out buttons</value>
        [XmlIgnore]
        public bool show_zoom_buttons { get; set; }

        [XmlElement("show_zoom_buttons"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_zoom_buttonsString
        {
            get { return show_zoom_buttons ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_zoom_buttons = true;
                }
                else if (value == no)
                {
                    show_zoom_buttons = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>zoom_out_button_x</summary>
        //<value>the zoom out button x position in pixels.</value>
        public int zoom_out_button_x { get; set; }

        //<summary>zoom_out_button_y</summary>
        //<value>the zoom out button y position in pixels.</value>
        public int zoom_out_button_y { get; set; }

        //<summary>zoom_out_button_normal_state</summary>
        //<value>the zoom out button image icon normal state image path.</value>
        public string zoom_out_button_normal_state { get; set; }

        //<summary>zoom_out_button_selected_state</summary>
        //<value>the zoom out button image icon selected state image path.</value>
        public string zoom_out_button_selected_state { get; set; }

        //<summary>zoom_in_button_x</summary>
        //<value>the zoom in button x position in pixels.</value>
        public int zoom_in_button_x { get; set; }

        //<summary>zoom_in_button_y</summary>
        //<value>the zoom in button y position in pixels.</value>
        public int zoom_in_button_y { get; set; }

        //<summary>zoom_in_button_normal_state</summary>
        //<value>the zoom in button image icon normal state image path.</value>
        public string zoom_in_button_normal_state { get; set; }

        //<summary>zoom_in_button_selected_state</summary>
        //<value>the zoom in button image icon selected state image path.</value>
        public string zoom_in_button_selected_state { get; set; }

        //<summary>lightbox_close_button_normal_state</summary>
        //<value>the lightbox close button icon normal state.</value>
        public string lightbox_close_button_normal_state { get; set; }

        //<summary>lightbox_close_button_selected_state</summary>
        //<value>the lightbox close button icon selected state.</value>
        public string lightbox_close_button_selected_state { get; set; }

        //<summary>show_board</summary>
        //<value>hide or show the mini map (navigator).</value>
        [XmlIgnore]
        public bool show_board { get; set; }

        [XmlElement("show_board"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_boardString
        {
            get { return show_board ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_board = true;
                }
                else if (value == no)
                {
                    show_board = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //<summary>board_x</summary>
        //<value>the navigator x position in pixels.</value>
        public int board_x { get; set; }

        //<summary>board_y</summary>
        //<value>the navigator y position in pixels.</value>
        public int board_y { get; set; }

        //<summary>board_border_size</summary>
        //<value>the navigator border size in pixels.</value>
        public int board_border_size { get; set; }

        //<summary>board_border_color</summary>
        //<value>the navigator border color.</value>
        public string board_border_color { get; set; }

        //<summary>board_dragger_color</summary>
        //<value>the navigator handler color, the draggable small rectangle.</value>
        public string board_dragger_color { get; set; }

        //<summary>board_border_opacity</summary>
        //<value>the navigator border opacity, a number form 0 to 1.</value>
        public float board_border_opacity { get; set; }

        //<summary>board_height</summary>
        //<value>the navigator total height, the width will be adjusted based on this height to keep the correct ratio.</value>
        public int board_height { get; set; }

        //<summary>preloaders_radius</summary>
        //<value>the image preloader radius.</value>
        public int preloaders_radius { get; set; }

        //<summary>preloader_thinckness</summary>
        //<value>the image preloader thinckness.</value>
        public int preloader_thinckness { get; set; }

        //<summary>preloaders_background_color</summary>
        //<value>the image preloader background color.</value>
        public string preloaders_background_color { get; set; }

        //<summary>preloaders_fill_color</summary>
        //<value>the image preloader fill color.</value>
        public string preloaders_fill_color { get; set; }

        //<summary>marker_button_normal_state</summary>
        //<value>the marker button icon normal state.</value>
        public string marker_button_normal_state { get; set; }

        //<summary>marker_button_selected_state_path</summary>
        //<value>the marker button icon selected state.</value>
        public string marker_button_selected_state_path { get; set; }

        //<summary>marker_registration_point</summary>
        //<value>the marker zoom registration point, it can be bottom or bottomCenter, this is explained in the "Setup the markers and tool tips" section.</value>
        public MarkerZoomRegistrationPoints marker_registration_point { get; set; }

        //<summary>tool_tip_border_size</summary>
        //<value>the tool tip border size.</value>
        public int tool_tip_border_size { get; set; }

        //<summary>tool_tip_border_radius</summary>
        //<value>the tool tip border radius.</value>
        public int tool_tip_border_radius { get; set; }

        //<summary>tool_tip_border_color</summary>
        //<value>the tool tip border color.</value>
        public string tool_tip_border_color { get; set; }

        //<summary>tool_tip_border_color</summary>
        //<value>the tool tip opacity, a number from 0 to 1.</value>
        public float tool_tip_border_opacity { get; set; }

        //<summary>tool_tip_background_color</summary>
        //<value>the tool tip background color.</value>
        public string tool_tip_background_color { get; set; }

        //<summary></summary>
        //<value></value>
        [XmlElement("marker")]
        public List<Marker> markers { get; private set; }

        public ZoomerConfig()
        {
            this.markers = new List<Marker>();
        }

    }
}
