import { Movie } from "./movie.model";

export class Studio {
  constructor(
    public studioId?: number,
    public name?: string,
    public city?: string,
    public state?: string,
    public movies?: Movie[]
  ) {

  }
}
