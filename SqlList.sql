create PROCEDURE MoviesListGet
(
	 @keyword nvarchar(100)
)
AS 
BEGIN
	if @keyword='' begin
		Select * from Movies order by Title
	 end
	else begin
		Select * from Movies where Title + ' ' + Director + ' ' + Casts like '%'+@keyword+'%' order by Title
	end
  --+ ' ' + Director + ' ' + [Casts]
END


create PROCEDURE CinemaListGet
(
	 @keyword nvarchar(100)
)
AS 
BEGIN
	if @keyword='' begin
		Select * from Cinemas order by Name
	 end
	else begin
		Select * from Cinemas where Name  like '%'+@keyword+'%'
	end
  
END

create PROCEDURE MovieScheduleList
(
	 @MovieId int
)
AS 
BEGIN
	if @MovieId>0 begin

		--Select a.MovieId,a.CinemaId,a.TakenSeats
		--    ,a.Id,c.Name,(SELECT CONVERT(VARCHAR(30),a.DateFrom))  AS DateFrom
		--	,convert(datetime,(SELECT CONVERT(VARCHAR(30),a.DateTo) )) AS DateTo
	 --       , convert(datetime,CONVERT(VARCHAR(8),TimeFrom,108)) as TimeFrom
		--    , convert(datetime,CONVERT(VARCHAR(8),TimeTo,108)) as TimeTo
		--    ,a.Price,a.RowLetter ,a.SeatPerRow 
		--from MovieSchedules a INNER JOIN Movies b ON a.MovieId=b.Id INNER JOIN Cinemas c ON a.CinemaId=c.Id 
		--WHERE b.Id=@MovieId

		Select a.MovieId,a.CinemaId,a.TakenSeats
		    ,a.Id,c.Name,a.DateFrom
			,a.DateTo
	        , a.TimeFrom
		    ,a.TimeTo
		    ,a.Price,a.RowLetter ,a.SeatPerRow 
		from MovieSchedules a INNER JOIN Movies b ON a.MovieId=b.Id INNER JOIN Cinemas c ON a.CinemaId=c.Id 
		WHERE b.Id=@MovieId

	end
  --a.Id,c.Name,a.DateFrom,a.DateTo,a.TimeFrom,a.TimeTo,a.Price,a.RowLetter,a.SeatPerRow 
END
