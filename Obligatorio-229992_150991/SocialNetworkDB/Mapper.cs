using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class Mapper
    {
        public UserEntity UserToEntity(User user)
        {
            PasswordEntity password = PasswordToEntity(user.Password);
            DirectionEntity direction = DirectionToEntity(user.Direction);
            PhotoEntity photo = PhotoToEntity(user.Avatar);
            UserEntity userEntity = new UserEntity
            {
                Username = user.Username,
                Name = user.Name,
                LastName = user.Lastname,
                Password = password,
                DateOfBirth = user.DateOfBirth,
                Direction = direction,
                Avatar = photo,
                Admin = user.Admin
            };
            return userEntity;
        }
        public User EntityToUser(UserEntity userEntity)
        {
            PasswordEntity entityPass = userEntity.Password;
            DirectionEntity entityDirection = userEntity.Direction;
            PhotoEntity photoEntity = userEntity.Avatar;
            Password password = EntityToPassword(entityPass);
            Direction direction = EntityToDirection(entityDirection);
            Photo photo = EntityToPhoto(photoEntity);
            User user = new User(userEntity.Username, password, userEntity.Name, userEntity.LastName, userEntity.DateOfBirth, direction, photo, userEntity.Admin)
            {
                Id = userEntity.Id,
                Username = userEntity.Username,
                Name = userEntity.Name,
                Lastname = userEntity.LastName,
                Password = password,
                DateOfBirth = userEntity.DateOfBirth,
                Direction = direction,
                Avatar = photo,
                Admin = userEntity.Admin
            };
            return user;
        }
        public PasswordEntity PasswordToEntity(Password pass)
        {
            PasswordEntity passwordEntity = new PasswordEntity
            {
                Hashpassword = pass.Hashpassword
            };
            return passwordEntity;
        }
        public Password EntityToPassword(PasswordEntity passwordEntity)
        {
            Password password = new Password()
            {
                Id = passwordEntity.Id,
                Hashpassword = passwordEntity.Hashpassword
            };
            return password;
        }
        public DirectionEntity DirectionToEntity(Direction direction)
        {
            DirectionEntity directionEntity = new DirectionEntity
            {
                Id = direction.Id,
                Street = direction.Street,
                City = direction.City,
                Counrty = direction.Counrty
            };
            return directionEntity;
        }
        public Direction EntityToDirection(DirectionEntity directionEntity)
        {
            Direction direction = new Direction()
            {
                Id = directionEntity.Id,
                Street = directionEntity.Street,
                City = directionEntity.City,
                Counrty = directionEntity.Counrty
            };
            return direction;
        }
        public PhotoEntity PhotoToEntity(Photo photo)
        {
            PhotoEntity photoEntity = new PhotoEntity
            {
                Id = photo.Id,
                Path = photo.ElPath,
                Size = photo.ElSize
            };
            return photoEntity;
        }
        public Photo EntityToPhoto(PhotoEntity photoEntity)
        {
            Photo photo = new Photo()
            {
                Id = photoEntity.Id,
                ElPath = photoEntity.Path,
                ElSize = photoEntity.Size
            };
            return photo;
        }
        public AlbumEntity AlbumToEntity(Album album)
        {
            AlbumEntity albumEntity = new AlbumEntity
            {
                Id = album.Id,
                Name = album.Name,
            };
            return albumEntity;
        }
        public Album EntityToAlbum(AlbumEntity albumEntity)
        {
            List<Photo> photos = new List<Photo>();
            List<PhotoEntity> photosEntity = (List<PhotoEntity>)albumEntity.Photos.ToList();
            foreach (PhotoEntity photo in photosEntity)
            {
                photos.Add(EntityToPhoto(photo));
            }
            Album album = new Album
            {
                Id = albumEntity.Id,
                Name = albumEntity.Name,
                PhotoList = photos
            };
            return album;
        }

        public ListeningNowEntity ListeningNowToEntity(ListeningNow song)
        {
            ListeningNowEntity songEntity = new ListeningNowEntity
            {
                Id = song.Id,
                SongName = song.SongName,
                Artist = song.Artist,
                AlbumName = song.AlbumName
            };
            return songEntity;
        }
        public ListeningNow EntityToListeningNow(ListeningNowEntity songEntity)
        {
            ListeningNow song = new ListeningNow()
            {
                Id = songEntity.Id,
                SongName = songEntity.SongName,
                Artist = songEntity.Artist,
                AlbumName = songEntity.AlbumName
            };
            return song;
        }
        public GameEntity GameToEntity(Game game)
        {
            GameEntity gameEntity = new GameEntity()
            {
                Id = game.Id,
                Name = game.Name,
                Category = game.Category,
                Cover = PhotoToEntity(game.Cover),
                Played = game.Played
            };
            return gameEntity;
        }
        public Game EntityToGame(GameEntity gameEntity)
        {
            Game game = new Game()
            {
                Id = gameEntity.Id,
                Name = gameEntity.Name,
                Category = gameEntity.Category,
                Cover = EntityToPhoto(gameEntity.Cover),
                Played = gameEntity.Played
            };
            return game;
        }
        public GameScoreEntity ScoreToEntity(GameScore score)
        {
            GameScoreEntity scoreEntity = new GameScoreEntity()
            {
                Id = score.Id,
                Name = score.Name,
                score = score.Score
            };
            return scoreEntity;
        }
        public GameScore EntityToScore(GameScoreEntity gameScoreEntity)
        {
            GameScore gameScore = new GameScore()
            {
                Id = gameScoreEntity.Id,
                Name = gameScoreEntity.Name,
                Score = gameScoreEntity.score
            };
            return gameScore;
        }
        public CommentEntity CommentToEntity(Comment comment)
        {
            CommentEntity commentEntity = new CommentEntity()
            {
                Id = comment.Id,
                TheComment = comment.TheComment,
                User = UserToEntity(comment.User),
                DateComment = comment.DateComment
            };
            return commentEntity;
        }
        public Comment EntityToComment(CommentEntity commentEntity)
        {
            //List<Reaction> reactions = new List<Reaction>();
            //List<ReactionEntity> reactionEntity = (List<ReactionEntity>)commentEntity.Reactions.ToList();
            List<Comment> coments = new List<Comment>();
            List<CommentEntity> commentListEntity = (List<CommentEntity>)commentEntity.Comments.ToList();
            foreach (CommentEntity comm in commentListEntity)
            {
                coments.Add(EntityToComment(comm));
            }
            //foreach(ReactionEntity react in reactionEntity)
            //{
            //    reactions.Add(EntityToReaction(react));
            //}
            Comment comment = new Comment()
            {
                Id = commentEntity.Id,
                //Reactions = reactions,
                Comments = coments,
                DateComment = commentEntity.DateComment,
                TheComment = commentEntity.TheComment,
                User = EntityToUser(commentEntity.User)
            };
            return comment;
        }
        public StatusEntity StatusToEntity(Status content)
        {
            StatusEntity contentEntity = new StatusEntity()
            {
                Id = content.Id,
                StatusBody = content.StatusBody
            };
            return contentEntity;
        }
        public Status EntityToStatus(StatusEntity contentEntity)
        {
            Status content = new Status()
            {
                Id = contentEntity.Id,
                StatusBody = contentEntity.StatusBody
            };
            return content;
        }
        public Reaction EntityToReaction(ReactionEntity reactionEntity)
        {
            Reaction reaction = new Reaction()
            {
                Id = reactionEntity.Id,
                ReactionName = reactionEntity.ReactionName,
                User = EntityToUser(reactionEntity.User)
            };
            return reaction;
        }
        public ReactionEntity ReactionToEntity(Reaction reaction)
        {
            ReactionEntity reactionEntity = new ReactionEntity()
            {
                Id = reaction.Id,
                ReactionName = reaction.ReactionName,
                User = UserToEntity(reaction.User)
            };
            return reactionEntity;
        }
    }
}
