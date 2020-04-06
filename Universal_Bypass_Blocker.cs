  public static void Block()
        {
            try
            {
                if(Directory.Exists($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Extensions\\ckiidekccfgninkobmmofopbbdgdclgg"))
                {
                    Console.WriteLine("Universal Bypass Detected ;( , Please Stop Trying To Bypass Our Key System..");
                    Console.ReadKey();
                    //Application.Exit();
                }
            }
            catch (IOException) { }
            try
            {
                if (Directory.Exists($"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\h3h9vg12.default - release\\storage\\default\\moz - extension++ + 97c1be04 - e171 - 476a - 91f2 - dfac08ae7108 ^ userContextId = 4294967295"))
                {
                    Console.WriteLine("Universal Bypass Detected ;( , Please Stop Trying To Bypass Our Key System..");
                    Console.ReadKey();
                    //Application.Exit();
                }
            }
            catch(IOException) { }


            try
            {
                if (Directory.Exists($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp\\Universal.Bypass.for.Chromium-based.browsers_5540_87496175"))
                {
                    Console.WriteLine("Universal Bypass Detected ;( , Please Stop Trying To Bypass Our Key System..");
                    Console.ReadKey();
                    //Application.Exit();
                }
            }
            catch (IOException) { }

            try
            {
                foreach(string str in Directory.GetDirectories(Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data"))
                {
                    try
                    {
                       if(Directory.Exists(str + "\\Extensions"))
                        {
                            try
                            {
                               ;
                                if(Directory.Exists(str + "\\Extensions\\aihomhdhpnpmcnnbckjjcebjoikpihj"))
                                {
                                    try
                                    {
                                        Console.WriteLine("Universal Bypass Detected ;( , Please Stop Trying To Bypass Our Key System..");
                                        Console.ReadKey();
                                        //Application.Exit();
                                    }
                                    catch(Exception ex)
                                    {
                                        Console.WriteLine(ex);
                                    }
                                }
                            }
                            catch (IOException ex3)
                            {
                                Console.WriteLine(ex3);
                            }
                        }
                    }
                    catch (IOException io2)
                    {
                        Console.WriteLine(io2);
                    }
                }
            }
            catch (IOException io)
            {
                Console.WriteLine(io);
            }
        }