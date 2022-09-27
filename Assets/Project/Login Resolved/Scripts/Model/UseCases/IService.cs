namespace MVPLoginExample.Model.UseCases
{
    public interface IService<DataType>
    {
        void Send(DataType data);
    }
}