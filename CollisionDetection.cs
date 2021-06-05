using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class CollisionDetection
    {
        public Gametype type1;
        public Gametype type2;

        public ICollisionBehaviour behaviour;
        public CollisionDetection(Gametype type1, Gametype type2, ICollisionBehaviour behaviour)
        {
            this.type1 = type1;
            this.type2 = type2;
            this.behaviour = behaviour;
        }

        public void check(List<GameObject> objects)
        {
            for (int i = 0; i < objects.Count - 1; i++)
            {
                for (int j = 0; j < objects.Count; j++)
                {
                    GameObject firstObject = objects[i];
                    GameObject secondobject = objects[j];

                    if (firstObject.type.GetHashCode() == type1.GetHashCode()
                           && secondobject.type.GetHashCode() == type2.GetHashCode() &&
                           firstObject.pictureBox.Bounds.IntersectsWith(secondobject.pictureBox.Bounds))
                    {
                        behaviour.behaviour(secondobject);

                    }

                }

            }

        }

    }
}
