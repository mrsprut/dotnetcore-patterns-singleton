namespace org.tyaa.demo.cs.patterns.creational.singleton
{
    class King
    {
      private static King instance;
      public string name = "Richard";
      private King(){}
      public static King GetInstance() {
        return instance == null ? instance = new King() : instance;
      }
    }
}