class ex07 {
   public void resposta() {
      int[] baguanca_crescente = { 78, 55, 45, 98, 13, 40, 1, 100, 90, 12, 22, 45, 79, 35, 300, 1000, 3012};
      int[] baguanca_decrescente = { 78, 55, 45, 98, 13, 40, 1, 100, 90, 12, 22, 45, 79, 35, 300, 1000, 3012};
      int crescente;
      int decrescente;

      for (int j = 0; j <= baguanca_crescente.Length - 2; j++) {
         for (int i = 0; i <= baguanca_crescente.Length - 2; i++) {
            if (baguanca_crescente[i] > baguanca_crescente[i + 1]) {
               crescente= baguanca_crescente[i + 1];
               baguanca_crescente[i + 1] = baguanca_crescente[i];
               baguanca_crescente[i] = crescente;
            }
         }
      }
         
      for (int a = 0; a <= baguanca_decrescente.Length - 2; a++) {
         for (int f = 0; f <= baguanca_decrescente.Length - 2; f++) {
            if (baguanca_decrescente[f] < baguanca_decrescente[f + 1]) {
               decrescente= baguanca_decrescente[f + 1];
               baguanca_decrescente[f + 1] = baguanca_decrescente[f];
               baguanca_decrescente[f] = decrescente;
            }
         }
      }

      Console.WriteLine("Ordenado de forma crescente:");
      foreach (int p in baguanca_crescente)
      Console.Write(p + "  " );
      
      Console.WriteLine(" ");
      
      Console.WriteLine("Ordenado de forma decrescente:");
      foreach (int s in baguanca_decrescente)
      Console.Write(s + "  ");
         
      Console.Read();
   }
}