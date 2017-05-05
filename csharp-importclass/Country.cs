using System;
namespace csharp_importclass {
	public class Country {
		public string name { get; set; }
		public string population { get; set; }
        public string[] states { get; set; }
        public City best_city { get; set; }

        public int fav_cnt() {
            return states.Length;
        }
	 }

    public class City {
        public string name { get; set; }
        public string population { get; set; }
    }
}
