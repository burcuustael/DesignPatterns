namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private VisitRouteMover _routeMover;

        public VisitRouteIterator(VisitRouteMover routeMover)
        {
            _routeMover = routeMover;
        }

        private int currentIndex = 0;
        public VisitRoute CurrentItem { get; set;}

        public bool NextLocation()
        {
            if (currentIndex < _routeMover.visitRoutes.Count)
            {
                CurrentItem = _routeMover.visitRoutes[currentIndex++];
                return true;
            }

            {
                return false;
            }
        }
    }
}
