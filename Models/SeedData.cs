using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DVDMovie.Models;

namespace DVDMovie
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            if (context.Database.GetMigrations().Count() > 0
                    && context.Database.GetPendingMigrations().Count() == 0
                    && context.Movies.Count() == 0)
            {
                var s1 = new Studio
                {
                    Name = "Moonlight Entertainment",
                    City = "San Jose",
                    State = "CA"
                };
                var s2 = new Studio
                {
                    Name = "Paramount",
                    City = "Chikago",
                    State = "IL"
                };
                var s3 = new Studio
                {
                    Name = "MGM",
                    City = "New York",
                    State = "NY"
                };

                context.Movies.AddRange(
                    new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                    new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    },
                                        new Movie {
                        Name = "Titanic",
                        Description = "",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 },
                            new Rating { Stars = 3 }
                        }
                    }
                );

                context.SaveChanges();
            }
        }
    }
}