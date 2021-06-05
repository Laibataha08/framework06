using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace WindowsFormsApp4
{
    class MovementFactory
    {
        IMovement movement;
        public static int objectsform;

        public static ArrayList availableObjects = new ArrayList();
        public static ArrayList occupiedObjects = new ArrayList();

        private static MovementFactory a;
       

        private MovementFactory()
        {

        }

        public static MovementFactory getInstance()
        {
            if (a == null)
            {
                a = new MovementFactory();
            }
            return a;
        }



        public IMovement getobjects(Type type)
        {
            int found = 0;

            foreach (object gameobjects in availableObjects)
            {
                IMovement g = (IMovement)gameobjects;
                if (g.GetType() == type)
                {

                    return g;
                    found = 1;
                }   
            }

            if (found == 0)
            {
                if (type == typeof(MoveLeft))
                {
                    MoveLeft ml = new MoveLeft();
                    availableObjects.Add(ml);
                    objectsform++;
                    return ml;
                }

                if (type == typeof(MoveRight))
                {
                    MoveRight mr = new MoveRight();
                    availableObjects.Add(mr);
                    objectsform++;
                    return mr;
                }

                if (type == typeof(Falling))
                {
                    Falling f = new Falling();
                    availableObjects.Add(f);
                    objectsform++;
                    return f;
                }

                if (type == typeof(movewithkeyboard))
                {
                    movewithkeyboard mk = new movewithkeyboard();
                    occupiedObjects.Add(mk);
                    objectsform++;
                    return mk;
                }
            }
            return new MoveRight();
        }

        public void releaseObjects(IMovement m)
        {

            for (int idx = 0; idx < occupiedObjects.Count; idx++)
            {
                IMovement h = (IMovement)occupiedObjects[idx];
                if (h.GetType() == m.GetType())
                {
                    availableObjects.Add(h);
                    occupiedObjects.Remove(h);  
                }
            }
        }

        public int totalobjects()
        {
            return objectsform;
        }

    }
}
