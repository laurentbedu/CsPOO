namespace CsPOO
{
    internal interface IClonable<T> where T : class
    {
        public T Clone(T other);

    }
}
