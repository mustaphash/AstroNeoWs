﻿namespace Models.Asteroids
{
    public class CloseApproachData
    {
        public string close_approach_date { get; set; }

        public string close_approach_date_full { get; set; }

        public long epoch_date_close_approach { get; set; }

        public RelativeVelocity relative_velocity { get; set; }

        public MissDistance miss_distance { get; set; }

        public string orbiting_body { get; set; }
    }
}
