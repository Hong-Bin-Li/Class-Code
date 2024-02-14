namespace Set{
	public class Set<Element> where Element : IComparable{
		public List<Element> set;


		public Set(){
			set = new List<Element>();
		}

		public Set(List<Element> set){
			this.set = set;
		}


		//NOTE - Add functions here

	}
}
