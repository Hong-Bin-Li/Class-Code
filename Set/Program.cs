namespace Set{
public class Set<Element> where Element : IComparable{
    public List<Element> set;
    public Set(){
        set = new List<Element>();
    }
    public Set(List<Element> set) {
        this.set = set;
    }

    // NOTE - Add functions here

    // Union Set operator
    public static Set<Element> operator | (Set<Element> s1, Set<Element> s2)
    {
        List<Element> unionSet = new List<Element>(s1.set);
        foreach (var ele in s2.set)
        {
            if(!unionSet.Contains(ele))
            {
                unionSet.Add(ele);
            }
        }
        return new Set<Element>(unionSet);
    }

    // Intersection Set Operator
    public static Set<Element> operator & (Set<Element> s1, Set<Element> s2)
    {
        List<Element> intersectSet = new List<Element>(s1.set);
        foreach (var ele in s2.set)
        {
            if(s2.set.Contains(ele))
            {
                intersectSet.Add(ele);
            }
        }
        return new Set<Element> (intersectSet);
    }

    // Set Difference Operator
    public static Set<Element> operator - (Set<Element> s1, Set<Element> s2)
    {
        List<Element> diffSet = new List<Element>(s1.set);
        foreach ( var ele in s2.set)
        {
            diffSet.Remove(ele);
        }

        return new Set<Element> (diffSet);
    }
    
    //Add one Sigle Element Operator
    public static Set<Element> operator + (Set<Element> s1, Element ele)
    {
        s1.set.Add(ele);
        return s1;
    }

    // Comparing set for equivalency 
    public static bool operator == (Set<Element> s1, Set<Element> s2)
    {
        if(ReferenceEquals(s1,s2))
        {
            return true;
        }
        if(s1 is null || s2 is null)
        {
            return false;
        }

        return s1.set.Count == s1.set.Count && s1.set.All(s2.set.Contains);
    }

    // Comparing Set for non-equivalency
    public static bool operator !=(Set<Element> s1, Set<Element> s2)
    {
        return ! (s1 == s2) ; //using the existed overloading operator
    }

}
}