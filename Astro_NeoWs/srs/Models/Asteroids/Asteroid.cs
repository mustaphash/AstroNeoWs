using System.Collections.Generic;

namespace Models.Asteroids
{
    public class Asteroid
    {
        public Links links { get; set; }

        public string id { get; set; }

        public string neo_reference_id { get; set; }

        public string name { get; set; }

        public string designation { get; set; }

        public string nasa_jpl_url { get; set; }

        public double absolute_magnitude_h { get; set; }

        public EstimatedDiameter estimated_diameter { get; set; }

        public bool is_potentially_hazardous_asteroid { get; set; }

        public List<CloseApproachData> close_approach_data { get; set; }

        public OrbitalData orbital_data { get; set; }

        public bool is_sentry_object { get; set; }
    }
}
