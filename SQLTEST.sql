
SELECT 
	ff.PremisesId
	,isNull(p.StreetNo,'') as StreetNo
	,IsNull(p.[Street],'') AS Street
	,ISNULL(b.Business,'') AS Business
	,SUM(isnull(ff.[Count],0)) as [Count]
FROM
	dbo.Footfall (NOLOCK) ff
INNER JOIN 
	dbo.[Premises] (NOLOCK) p
	ON 
		ff.[PremisesId] = p.[Id]
INNER JOIN
	dbo.[Businesses] b (NOLOCK)
    ON
		p.[BusinessId] = b.Id
GROUP BY
   ff.[PremisesId],
   p.[StreetNo],
   p.[Street],
   b.[Business]
ORDER BY 
  ff.PremisesId
  

  
   

 


--INNER JOIN 
--	dbo.Premises (NOLOCK) p
--	ON 
--		ff.Premisesld = p.Id
--INNER JOIN
--	dbo.[Businesses] b (NOLOCK)
--    ON
--		p.BusinessId = b.Id
--Group By 
--	ff.[Premisesld],
--	b.[Business],
--	ff.[Count],
	
--	p.[StreetNo],
--	p.[Street],
--	p.[PostCode]



