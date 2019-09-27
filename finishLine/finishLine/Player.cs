using System;

namespace finishLine
{
    public class Player
    {
        public FLMarker[] markers;
        public string name;

        public Player(string name, string[] markerNames)
        {
            markers = new FLMarker[markerNames.Length];
            this.name = name;
            for (int markerName = 0; markerName < markerNames.Length; markerName++)
            {
                markers[markerName] = new FLMarker(markerNames[markerName]);
            }
        }

        public string HasMarkersAt(int position)
        {
            string master = "";
            foreach (var marker in markers)
            {
                if (marker.position == position)
                {
                    master += marker.name;
                }
                else
                {
                    master += " ";
                }
            }
            return master;
        }

        public int FindMarker(string query)
        {
            for (int counter = 0; counter < this.markers.Length; counter++)
            {
                if (markers[counter].name == query)
                    return counter;
            }

            return -1;
        }
    }
}
