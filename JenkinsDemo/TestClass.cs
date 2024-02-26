namespace JenkinsDemo
{
    public class TestClass
    {
        public String sayJenkins(int times)
        {
            String Output = "";
            for (int i = 0; i < times; i++)
            {
                Output += "Jenkins ";
            }
            return Output;
        }
    }
}
