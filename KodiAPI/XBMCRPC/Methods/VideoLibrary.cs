using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace XBMCRPC.Methods
{
    public partial class VideoLibrary
    {
        private readonly Client _client;
        public VideoLibrary(Client client)
        {
            _client = client;
        }

        /// <summary>
        /// Cleans the video library from non-existent items
        /// </summary>
        public async Task<string> Clean()
        {
            var jArgs = new JObject();
            return await _client.GetData<string>("VideoLibrary.Clean", jArgs);
        }

        /// <summary>
        /// Exports all items from the video library
        /// </summary>
        public async Task<string> Export(XBMCRPC.VideoLibrary.Export_optionsPath options)
        {
            var jArgs = new JObject();
            if (options != null)
            {
                var jpropoptions = JToken.FromObject(options, _client.Serializer);
                jArgs.Add(new JProperty("options", jpropoptions));
            }
            return await _client.GetData<string>("VideoLibrary.Export", jArgs);
        }

        /// <summary>
        /// Exports all items from the video library
        /// </summary>
        public async Task<string> Export(XBMCRPC.VideoLibrary.Export_options1 options)
        {
            var jArgs = new JObject();
            if (options != null)
            {
                var jpropoptions = JToken.FromObject(options, _client.Serializer);
                jArgs.Add(new JProperty("options", jpropoptions));
            }
            return await _client.GetData<string>("VideoLibrary.Export", jArgs);
        }

        /// <summary>
        /// Exports all items from the video library
        /// </summary>
        public async Task<string> Export()
        {
            var jArgs = new JObject();
            return await _client.GetData<string>("VideoLibrary.Export", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific tv show episode
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetEpisodeDetailsResponse> GetEpisodeDetails(
            int episodeid,
            Video.Fields.Episode properties = null
            )
        {
            var jArgs = new JObject();
            var jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
            jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetEpisodeDetailsResponse>("VideoLibrary.GetEpisodeDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetEpisodesResponse> GetEpisodes(
            int? tvshowid = null,
            int? season = null,
            Video.Fields.Episode properties = null,
            List.Limits limits = null,
            List.Sort sort = null,
            List.Filter.EpisodesAnd filter = null
            )
        {
            var jArgs = new JObject();
            if (tvshowid != null)
            {
                var jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                var jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all genres
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetGenresResponse> GetGenres(
            XBMCRPC.VideoLibrary.GetGenres_type type,
            Library.Fields.Genre properties = null,
            List.Limits limits = null,
            List.Sort sort = null
            )
        {
            var jArgs = new JObject();
            var jproptype = JToken.FromObject(type, _client.Serializer);
            jArgs.Add(new JProperty("type", jproptype));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetGenresResponse>("VideoLibrary.GetGenres", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific movie
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetMovieDetailsResponse> GetMovieDetails(
            int movieid,
            Video.Fields.Movie properties = null
            )
        {
            var jArgs = new JObject();
            var jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
            jArgs.Add(new JProperty("movieid", jpropmovieid));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetMovieDetailsResponse>("VideoLibrary.GetMovieDetails", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific movie set
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetMovieSetDetailsResponse> GetMovieSetDetails(
            int setid,
            Video.Fields.MovieSet properties = null,
            XBMCRPC.VideoLibrary.GetMovieSetDetails_movies movies = null
            )
        {
            var jArgs = new JObject();
            var jpropsetid = JToken.FromObject(setid, _client.Serializer);
            jArgs.Add(new JProperty("setid", jpropsetid));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (movies != null)
            {
                var jpropmovies = JToken.FromObject(movies, _client.Serializer);
                jArgs.Add(new JProperty("movies", jpropmovies));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetMovieSetDetailsResponse>("VideoLibrary.GetMovieSetDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all movie sets
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetMovieSetsResponse> GetMovieSets(
            Video.Fields.MovieSet properties = null,
            List.Limits limits = null,
            List.Sort sort = null
            )
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetMovieSetsResponse>("VideoLibrary.GetMovieSets", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetMoviesResponse> GetMovies(
            Video.Fields.Movie properties = null,
            List.Limits limits = null,
            List.Sort sort = null,
            List.Filter.MoviesAnd filter = null
            )
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific music video
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetMusicVideoDetailsResponse> GetMusicVideoDetails(
            int musicvideoid,
            Video.Fields.MusicVideo properties = null
            )
        {
            var jArgs = new JObject();
            var jpropmusicvideoid = JToken.FromObject(musicvideoid, _client.Serializer);
            jArgs.Add(new JProperty("musicvideoid", jpropmusicvideoid));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetMusicVideoDetailsResponse>("VideoLibrary.GetMusicVideoDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetMusicVideosResponse> GetMusicVideos(
            Video.Fields.MusicVideo properties = null,
            List.Limits limits = null,
            List.Sort sort = null,
            List.Filter.MusicVideosAnd filter = null
            )
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all recently added tv episodes
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetRecentlyAddedEpisodesResponse> GetRecentlyAddedEpisodes(
            Video.Fields.Episode properties = null,
            List.Limits limits = null,
            List.Sort sort = null
            )
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetRecentlyAddedEpisodesResponse>("VideoLibrary.GetRecentlyAddedEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all recently added movies
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetRecentlyAddedMoviesResponse> GetRecentlyAddedMovies(
            Video.Fields.Movie properties = null,
            List.Limits limits = null,
            List.Sort sort = null
            )
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetRecentlyAddedMoviesResponse>("VideoLibrary.GetRecentlyAddedMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all recently added music videos
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetRecentlyAddedMusicVideosResponse> GetRecentlyAddedMusicVideos(XBMCRPC.Video.Fields.MusicVideo properties = null, XBMCRPC.List.Limits limits = null, XBMCRPC.List.Sort sort = null)
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetRecentlyAddedMusicVideosResponse>("VideoLibrary.GetRecentlyAddedMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific tv show season
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetSeasonDetailsResponse> GetSeasonDetails(
            int seasonid,
            Video.Fields.Season properties = null
            )
        {
            var jArgs = new JObject();
            var jpropseasonid = JToken.FromObject(seasonid, _client.Serializer);
            jArgs.Add(new JProperty("seasonid", jpropseasonid));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetSeasonDetailsResponse>("VideoLibrary.GetSeasonDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all tv seasons
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetSeasonsResponse> GetSeasons(
            int? tvshowid = null,
            Video.Fields.Season properties = null,
            List.Limits limits = null,
            List.Sort sort = null
            )
        {
            var jArgs = new JObject();
            if (tvshowid != null)
            {
                var jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetSeasonsResponse>("VideoLibrary.GetSeasons", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific tv show
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetTVShowDetailsResponse> GetTVShowDetails(
            int tvshowid,
            Video.Fields.TVShow properties = null
            )
        {
            var jArgs = new JObject();
            var jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
            jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetTVShowDetailsResponse>("VideoLibrary.GetTVShowDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<XBMCRPC.VideoLibrary.GetTVShowsResponse> GetTVShows(
            Video.Fields.TVShow properties = null,
            List.Limits limits = null,
            List.Sort sort = null,
            List.Filter.TVShowsAnd filter = null
            )
        {
            var jArgs = new JObject();
            if (properties != null)
            {
                var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                var jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                var jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<XBMCRPC.VideoLibrary.GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Removes the given episode from the library
        /// </summary>
        public async Task<string> RemoveEpisode(int episodeid)
        {
            var jArgs = new JObject();
            var jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
            jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            return await _client.GetData<string>("VideoLibrary.RemoveEpisode", jArgs);
        }

        /// <summary>
        /// Removes the given movie from the library
        /// </summary>
        public async Task<string> RemoveMovie(int movieid)
        {
            var jArgs = new JObject();
            var jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
            jArgs.Add(new JProperty("movieid", jpropmovieid));
            return await _client.GetData<string>("VideoLibrary.RemoveMovie", jArgs);
        }

        /// <summary>
        /// Removes the given music video from the library
        /// </summary>
        public async Task<string> RemoveMusicVideo(int musicvideoid)
        {
            var jArgs = new JObject();
            var jpropmusicvideoid = JToken.FromObject(musicvideoid, _client.Serializer);
            jArgs.Add(new JProperty("musicvideoid", jpropmusicvideoid));
            return await _client.GetData<string>("VideoLibrary.RemoveMusicVideo", jArgs);
        }

        /// <summary>
        /// Removes the given tv show from the library
        /// </summary>
        public async Task<string> RemoveTVShow(int tvshowid)
        {
            var jArgs = new JObject();
            var jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
            jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            return await _client.GetData<string>("VideoLibrary.RemoveTVShow", jArgs);
        }

        /// <summary>
        /// Scans the video sources for new library items
        /// </summary>
        public async Task<string> Scan(string directory = null)
        {
            var jArgs = new JObject();
            if (directory != null)
            {
                var jpropdirectory = JToken.FromObject(directory, _client.Serializer);
                jArgs.Add(new JProperty("directory", jpropdirectory));
            }
            return await _client.GetData<string>("VideoLibrary.Scan", jArgs);
        }

        /// <summary>
        /// Update the given episode with the given details
        /// </summary>
        public async Task<string> SetEpisodeDetails(
            int episodeid,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            global::System.Collections.Generic.List<string> director = null,
            string plot = null,
            double? rating = null,
            string votes = null,
            string lastplayed = null,
            global::System.Collections.Generic.List<string> writer = null,
            string firstaired = null,
            string productioncode = null,
            int? season = null,
            int? episode = null,
            string originaltitle = null,
            string thumbnail = null,
            string fanart = null,
            global::System.Collections.Generic.Dictionary<string, string> art = null,
            Video.Resume resume = null,
            int? userrating = null,
            global::System.Collections.Generic.Dictionary<string, Video.Rating> ratings = null,
            string dateadded = null,
            global::System.Collections.Generic.Dictionary<string, string> uniqueid = null
            )
        {
            var apiversion = await _client.GetData<XBMCRPC.JSONRPC.VersionResponse>("JSONRPC.Version", new JObject());
            var jArgs = new JObject();
            var jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
            jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            if (title != null)
            {
                var jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                var jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                var jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                var jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (plot != null)
            {
                var jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (rating != null)
            {
                var jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (votes != null)
            {
                var jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                var jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (writer != null)
            {
                var jpropwriter = JToken.FromObject(writer, _client.Serializer);
                jArgs.Add(new JProperty("writer", jpropwriter));
            }
            if (firstaired != null)
            {
                var jpropfirstaired = JToken.FromObject(firstaired, _client.Serializer);
                jArgs.Add(new JProperty("firstaired", jpropfirstaired));
            }
            if (productioncode != null)
            {
                var jpropproductioncode = JToken.FromObject(productioncode, _client.Serializer);
                jArgs.Add(new JProperty("productioncode", jpropproductioncode));
            }
            if (season != null)
            {
                var jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (episode != null)
            {
                var jpropepisode = JToken.FromObject(episode, _client.Serializer);
                jArgs.Add(new JProperty("episode", jpropepisode));
            }
            if (originaltitle != null)
            {
                var jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (thumbnail != null)
            {
                var jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                var jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (art != null)
            {
                var jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (apiversion.version.major >= 8)
            {
                if (resume != null)
                {
                    var jpropresume = JToken.FromObject(resume, _client.Serializer);
                    jArgs.Add(new JProperty("resume", jpropresume));
                }
                if (userrating != null)
                {
                    var jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                    jArgs.Add(new JProperty("userrating", jpropuserrating));
                }
                if (ratings != null)
                {
                    var jpropratings = JToken.FromObject(ratings, _client.Serializer);
                    jArgs.Add(new JProperty("ratings", jpropratings));
                }
                if (dateadded != null)
                {
                    var jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                    jArgs.Add(new JProperty("dateadded", jpropdateadded));
                }
                if (uniqueid != null)
                {
                    var jpropuniqueid = JToken.FromObject(uniqueid, _client.Serializer);
                    jArgs.Add(new JProperty("uniqueid", jpropuniqueid));
                }
            }
            return await _client.GetData<string>("VideoLibrary.SetEpisodeDetails", jArgs);
        }

        /// <summary>
        /// Update the given movie with the given details
        /// </summary>
        public async Task<string> SetMovieDetails(
            int movieid,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            global::System.Collections.Generic.List<string> director = null,
            global::System.Collections.Generic.List<string> studio = null,
            int? year = null,
            string plot = null,
            global::System.Collections.Generic.List<string> genre = null,
            double? rating = null,
            string mpaa = null,
            string imdbnumber = null,
            string votes = null,
            string lastplayed = null,
            string originaltitle = null,
            string trailer = null,
            string tagline = null,
            string plotoutline = null,
            global::System.Collections.Generic.List<string> writer = null,
            global::System.Collections.Generic.List<string> country = null,
            int? top250 = null,
            string sorttitle = null,
            string set = null,
            global::System.Collections.Generic.List<string> showlink = null,
            string thumbnail = null,
            string fanart = null,
            global::System.Collections.Generic.List<string> tag = null,
            global::System.Collections.Generic.Dictionary<string, string> art = null,
            Video.Resume resume = null,
            int? userrating = null,
            global::System.Collections.Generic.Dictionary<string, Video.Rating> ratings = null,
            string dateadded = null,
            string premiered = null,
            global::System.Collections.Generic.Dictionary<string, string> uniqueid = null)
        {
            var apiversion = await _client.GetData<XBMCRPC.JSONRPC.VersionResponse>("JSONRPC.Version", new JObject());
            var jArgs = new JObject();
            var jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
            jArgs.Add(new JProperty("movieid", jpropmovieid));
            if (title != null)
            {
                var jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                var jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                var jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                var jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (studio != null)
            {
                var jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (year != null)
            {
                var jpropyear = JToken.FromObject(year, _client.Serializer);
                jArgs.Add(new JProperty("year", jpropyear));
            }
            if (plot != null)
            {
                var jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (genre != null)
            {
                var jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (rating != null)
            {
                var jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (mpaa != null)
            {
                var jpropmpaa = JToken.FromObject(mpaa, _client.Serializer);
                jArgs.Add(new JProperty("mpaa", jpropmpaa));
            }
            if (imdbnumber != null)
            {
                var jpropimdbnumber = JToken.FromObject(imdbnumber, _client.Serializer);
                jArgs.Add(new JProperty("imdbnumber", jpropimdbnumber));
            }
            if (votes != null)
            {
                var jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                var jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (originaltitle != null)
            {
                var jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (trailer != null)
            {
                var jproptrailer = JToken.FromObject(trailer, _client.Serializer);
                jArgs.Add(new JProperty("trailer", jproptrailer));
            }
            if (tagline != null)
            {
                var jproptagline = JToken.FromObject(tagline, _client.Serializer);
                jArgs.Add(new JProperty("tagline", jproptagline));
            }
            if (plotoutline != null)
            {
                var jpropplotoutline = JToken.FromObject(plotoutline, _client.Serializer);
                jArgs.Add(new JProperty("plotoutline", jpropplotoutline));
            }
            if (writer != null)
            {
                var jpropwriter = JToken.FromObject(writer, _client.Serializer);
                jArgs.Add(new JProperty("writer", jpropwriter));
            }
            if (country != null)
            {
                var jpropcountry = JToken.FromObject(country, _client.Serializer);
                jArgs.Add(new JProperty("country", jpropcountry));
            }
            if (top250 != null)
            {
                var jproptop250 = JToken.FromObject(top250, _client.Serializer);
                jArgs.Add(new JProperty("top250", jproptop250));
            }
            if (sorttitle != null)
            {
                var jpropsorttitle = JToken.FromObject(sorttitle, _client.Serializer);
                jArgs.Add(new JProperty("sorttitle", jpropsorttitle));
            }
            if (set != null)
            {
                var jpropset = JToken.FromObject(set, _client.Serializer);
                jArgs.Add(new JProperty("set", jpropset));
            }
            if (showlink != null)
            {
                var jpropshowlink = JToken.FromObject(showlink, _client.Serializer);
                jArgs.Add(new JProperty("showlink", jpropshowlink));
            }
            if (thumbnail != null)
            {
                var jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                var jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                var jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                var jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (apiversion.version.major >= 8)
            {
                if (resume != null)
                {
                    var jpropresume = JToken.FromObject(resume, _client.Serializer);
                    jArgs.Add(new JProperty("resume", jpropresume));
                }
                if (userrating != null)
                {
                    var jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                    jArgs.Add(new JProperty("userrating", jpropuserrating));
                }
                if (ratings != null)
                {
                    var jpropratings = JToken.FromObject(ratings, _client.Serializer);
                    jArgs.Add(new JProperty("ratings", jpropratings));
                }
                if (dateadded != null)
                {
                    var jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                    jArgs.Add(new JProperty("dateadded", jpropdateadded));
                }
                if (premiered != null)
                {
                    var jproppremiered = JToken.FromObject(premiered, _client.Serializer);
                    jArgs.Add(new JProperty("premiered", jproppremiered));
                }
                if (uniqueid != null)
                {
                    var jpropuniqueid = JToken.FromObject(uniqueid, _client.Serializer);
                    jArgs.Add(new JProperty("uniqueid", jpropuniqueid));
                }
            }
            return await _client.GetData<string>("VideoLibrary.SetMovieDetails", jArgs);
        }

        /// <summary>
        /// Update the given movie set with the given details
        /// </summary>
        public async Task<string> SetMovieSetDetails(
            int setid,
            string title = null,
            string plot = null,
            global::System.Collections.Generic.Dictionary<string, string> art = null)
        {
            var apiversion = await _client.GetData<XBMCRPC.JSONRPC.VersionResponse>("JSONRPC.Version", new JObject());
            if (apiversion.version.major >= 8)
            {
                var jArgs = new JObject();
                var jpropsetid = JToken.FromObject(setid, _client.Serializer);
                jArgs.Add(new JProperty("setid", jpropsetid));
                if (title != null)
                {
                    var jproptitle = JToken.FromObject(title, _client.Serializer);
                    jArgs.Add(new JProperty("title", jproptitle));
                }
                if (art != null)
                {
                    var jpropart = JToken.FromObject(art, _client.Serializer);
                    jArgs.Add(new JProperty("art", jpropart));
                }
                if (apiversion.version.major >= 10)
                {
                    if (plot != null)
                    {
                        var jpropplot = JToken.FromObject(plot, _client.Serializer);
                        jArgs.Add(new JProperty("plot", jpropplot));
                    }
                }
                return await _client.GetData<string>("VideoLibrary.SetMovieSetDetails", jArgs);
            }
            else
            {
                return "error (API version does not support updating movieset details)";
            }
        }

        /// <summary>
        /// Update the given music video with the given details
        /// </summary>
        public async Task<string> SetMusicVideoDetails(
            int musicvideoid,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            global::System.Collections.Generic.List<string> director = null,
            global::System.Collections.Generic.List<string> studio = null,
            int? year = null,
            string plot = null,
            string album = null,
            global::System.Collections.Generic.List<string> artist = null,
            global::System.Collections.Generic.List<string> genre = null,
            int? track = null,
            string lastplayed = null,
            string thumbnail = null,
            string fanart = null,
            global::System.Collections.Generic.List<string> tag = null,
            global::System.Collections.Generic.Dictionary<string, string> art = null,
            Video.Resume resume = null,
            double? rating = null,
            int? userrating = null,
            string dateadded = null,
            string premiered = null)
        {
            var apiversion = await _client.GetData<XBMCRPC.JSONRPC.VersionResponse>("JSONRPC.Version", new JObject());
            var jArgs = new JObject();
            var jpropmusicvideoid = JToken.FromObject(musicvideoid, _client.Serializer);
            jArgs.Add(new JProperty("musicvideoid", jpropmusicvideoid));
            if (title != null)
            {
                var jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                var jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                var jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                var jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (studio != null)
            {
                var jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (year != null)
            {
                var jpropyear = JToken.FromObject(year, _client.Serializer);
                jArgs.Add(new JProperty("year", jpropyear));
            }
            if (plot != null)
            {
                var jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (album != null)
            {
                var jpropalbum = JToken.FromObject(album, _client.Serializer);
                jArgs.Add(new JProperty("album", jpropalbum));
            }
            if (artist != null)
            {
                var jpropartist = JToken.FromObject(artist, _client.Serializer);
                jArgs.Add(new JProperty("artist", jpropartist));
            }
            if (genre != null)
            {
                var jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (track != null)
            {
                var jproptrack = JToken.FromObject(track, _client.Serializer);
                jArgs.Add(new JProperty("track", jproptrack));
            }
            if (lastplayed != null)
            {
                var jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (thumbnail != null)
            {
                var jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                var jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                var jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                var jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (apiversion.version.major >= 8)
            {
                if (resume != null)
                {
                    var jpropresume = JToken.FromObject(resume, _client.Serializer);
                    jArgs.Add(new JProperty("resume", jpropresume));
                }
                if (rating != null)
                {
                    var jproprating = JToken.FromObject(rating, _client.Serializer);
                    jArgs.Add(new JProperty("rating", jproprating));
                }
                if (userrating != null)
                {
                    var jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                    jArgs.Add(new JProperty("userrating", jpropuserrating));
                }
                if (dateadded != null)
                {
                    var jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                    jArgs.Add(new JProperty("dateadded", jpropdateadded));
                }
                if (premiered != null)
                {
                    var jproppremiered = JToken.FromObject(premiered, _client.Serializer);
                    jArgs.Add(new JProperty("premiered", jproppremiered));
                }
            }
            return await _client.GetData<string>("VideoLibrary.SetMusicVideoDetails", jArgs);
        }

        /// <summary>
        /// Update the given season with the given details
        /// </summary>
        public async Task<string> SetSeasonDetails(
            int seasonid,
            global::System.Collections.Generic.Dictionary<string, string> art = null,
            int? userrating = null,
            string title = null)
        {
            var apiversion = await _client.GetData<XBMCRPC.JSONRPC.VersionResponse>("JSONRPC.Version", new JObject());
            if (apiversion.version.major >= 8)
            {
                var jArgs = new JObject();
                var jpropseasonid = JToken.FromObject(seasonid, _client.Serializer);
                jArgs.Add(new JProperty("seasonid", jpropseasonid));
                if (art != null)
                {
                    var jpropart = JToken.FromObject(art, _client.Serializer);
                    jArgs.Add(new JProperty("art", jpropart));
                }
                if (userrating != null)
                {
                    var jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                    jArgs.Add(new JProperty("userrating", jpropuserrating));
                }
                if (apiversion.version.major >= 10)
                {
                    if (title != null)
                    {
                        var jproptitle = JToken.FromObject(title, _client.Serializer);
                        jArgs.Add(new JProperty("title", jproptitle));
                    }
                }
                return await _client.GetData<string>("VideoLibrary.SetSeasonDetails", jArgs);
            }
            else
            {
                return "error (API version does not support updating season details)";
            }
        }

        /// <summary>
        /// Update the given tvshow with the given details
        /// </summary>
        public async Task<string> SetTVShowDetails(
            int tvshowid,
            string title = null,
            int? playcount = null,
            global::System.Collections.Generic.List<string> studio = null,
            string plot = null,
            global::System.Collections.Generic.List<string> genre = null,
            double? rating = null,
            string mpaa = null,
            string imdbnumber = null,
            string premiered = null,
            string votes = null,
            string lastplayed = null,
            string originaltitle = null,
            string sorttitle = null,
            string episodeguide = null,
            string thumbnail = null,
            string fanart = null,
            global::System.Collections.Generic.List<string> tag = null,
            global::System.Collections.Generic.Dictionary<string, string> art = null,
            int? userrating = null,
            global::System.Collections.Generic.Dictionary<string, Video.Rating> ratings = null,
            string dateadded = null,
            int? runtime = null,
            string status = null,
            global::System.Collections.Generic.Dictionary<string, string> uniqueid = null
            )
        {
            var apiversion = await _client.GetData<XBMCRPC.JSONRPC.VersionResponse>("JSONRPC.Version", new JObject());
            var jArgs = new JObject();
            var jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
            jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            if (title != null)
            {
                var jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                var jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (studio != null)
            {
                var jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (plot != null)
            {
                var jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (genre != null)
            {
                var jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (rating != null)
            {
                var jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (mpaa != null)
            {
                var jpropmpaa = JToken.FromObject(mpaa, _client.Serializer);
                jArgs.Add(new JProperty("mpaa", jpropmpaa));
            }
            if (imdbnumber != null)
            {
                var jpropimdbnumber = JToken.FromObject(imdbnumber, _client.Serializer);
                jArgs.Add(new JProperty("imdbnumber", jpropimdbnumber));
            }
            if (premiered != null)
            {
                var jproppremiered = JToken.FromObject(premiered, _client.Serializer);
                jArgs.Add(new JProperty("premiered", jproppremiered));
            }
            if (votes != null)
            {
                var jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                var jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (originaltitle != null)
            {
                var jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (sorttitle != null)
            {
                var jpropsorttitle = JToken.FromObject(sorttitle, _client.Serializer);
                jArgs.Add(new JProperty("sorttitle", jpropsorttitle));
            }
            if (episodeguide != null)
            {
                var jpropepisodeguide = JToken.FromObject(episodeguide, _client.Serializer);
                jArgs.Add(new JProperty("episodeguide", jpropepisodeguide));
            }
            if (thumbnail != null)
            {
                var jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                var jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                var jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                var jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (apiversion.version.major >= 8)
            {
                if (userrating != null)
                {
                    var jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                    jArgs.Add(new JProperty("userrating", jpropuserrating));
                }
                if (ratings != null)
                {
                    var jpropratings = JToken.FromObject(ratings, _client.Serializer);
                    jArgs.Add(new JProperty("ratings", jpropratings));
                }
                if (dateadded != null)
                {
                    var jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                    jArgs.Add(new JProperty("dateadded", jpropdateadded));
                }
                if (runtime != null)
                {
                    var jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                    jArgs.Add(new JProperty("runtime", jpropruntime));
                }
                if (status != null)
                {
                    var jpropstatus = JToken.FromObject(status, _client.Serializer);
                    jArgs.Add(new JProperty("status", jpropstatus));
                }
                if (uniqueid != null)
                {
                    var jpropuniqueid = JToken.FromObject(uniqueid, _client.Serializer);
                    jArgs.Add(new JProperty("uniqueid", jpropuniqueid));
                }
            }
                return await _client.GetData<string>("VideoLibrary.SetTVShowDetails", jArgs);
        }

        public delegate void OnCleanFinishedDelegate(string sender = null, object data = null);
        public event OnCleanFinishedDelegate OnCleanFinished;
        internal void RaiseOnCleanFinished(string sender = null, object data = null)
        {
            if (OnCleanFinished != null)
            {
                OnCleanFinished.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnCleanStartedDelegate(string sender = null, object data = null);
        public event OnCleanStartedDelegate OnCleanStarted;
        internal void RaiseOnCleanStarted(string sender = null, object data = null)
        {
            if (OnCleanStarted != null)
            {
                OnCleanStarted.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnRemoveDelegate(string sender = null, XBMCRPC.VideoLibrary.OnRemove_data data = null);
        public event OnRemoveDelegate OnRemove;
        internal void RaiseOnRemove(string sender = null, XBMCRPC.VideoLibrary.OnRemove_data data = null)
        {
            if (OnRemove != null)
            {
                OnRemove.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnScanFinishedDelegate(string sender = null, object data = null);
        public event OnScanFinishedDelegate OnScanFinished;
        internal void RaiseOnScanFinished(string sender = null, object data = null)
        {
            if (OnScanFinished != null)
            {
                OnScanFinished.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnScanStartedDelegate(string sender = null, object data = null);
        public event OnScanStartedDelegate OnScanStarted;
        internal void RaiseOnScanStarted(string sender = null, object data = null)
        {
            if (OnScanStarted != null)
            {
                OnScanStarted.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnUpdateDelegate(string sender = null, XBMCRPC.VideoLibrary.OnUpdate_data data = null);
        public event OnUpdateDelegate OnUpdate;
        internal void RaiseOnUpdate(string sender = null, XBMCRPC.VideoLibrary.OnUpdate_data data = null)
        {
            if (OnUpdate != null)
            {
                OnUpdate.BeginInvoke(sender, data, null, null);
            }
        }
    }
}
