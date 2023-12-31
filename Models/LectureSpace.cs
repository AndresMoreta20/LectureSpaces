﻿namespace LectureSpace.models
{
    public class LectureSpace
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public Video video { get; set; }
        public Cuestionario cuestionario { get; set; }

        public virtual ICollection<Recurso> recursos { get; set; }
    }
}
