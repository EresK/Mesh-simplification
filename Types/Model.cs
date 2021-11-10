using System.Collections;
using System.Collections.Generic;

namespace PLY.Types{
    public class Model{
        
        public List<Face> Faces;
        public List<Edge> Edges;
        public List<Vertex<double>> Vertices;

        public Model(List<Face> faces, List<Edge> edges, List<Vertex<double>> vertices){
            Faces = faces;
            Edges = edges;
            Vertices = vertices;
        }

        public Model(){
            Faces = new List<Face>();
            Edges = new List<Edge>();
            Vertices = new List<Vertex<double>>();
        }
    }
}