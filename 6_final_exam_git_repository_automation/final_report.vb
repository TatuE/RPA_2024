If(numberOfGitRepositories=0,
	"GIT AUTOMATION REPORT, Date "+DateTime.Now.ToString("dd-MM-yyyy")+vbnewline+"No repositories found under root folder.",
		If(gitRepositoriesUpToDate.Count()=numberOfGitRepositories,
			"GIT AUTOMATION REPORT, Date "+DateTime.Now.ToString("dd-MM-yyyy")+vbnewline+"Git repositories found : "+numberOfGitRepositories.ToString+vbnewline+
			"All repositories were up to date with a clean working tree"+vbnewline+
			"Repositories included in processing : "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesUpToDate),
				If(gitRepositoriesWithErrors.Count()>0,
					"GIT AUTOMATION REPORT, Date "+DateTime.Now.ToString("dd-MM-yyyy")+vbnewline+"Git repositories found : "+numberOfGitRepositories.ToString+vbnewline+
						"There were errors found in "+gitRepositoriesWithErrors.Count().ToString()+" repositories: "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesWithErrors)+vbCrLf+
						"Number of repositories up to date "+gitRepositoriesUpToDate.Count().ToString()+", update to date repositories are : "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesUpToDate)+vbCrLf+
						"Number of repositories updated "+gitRepositoriesUpdated.Count().ToString()+", updated repositories are : "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesUpdated)+vbCrLf+
						"Number of repositories with changes not staged for commit "+gitRepositoriesWithCommits.Count().ToString()+" these repositories were nut updated. Repositories are "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesWithCommits),
					"GIT AUTOMATION REPORT, Date "+DateTime.Now.ToString("dd-MM-yyyy")+vbnewline+"Git repositories found : "+numberOfGitRepositories.ToString+vbnewline+
						"Number of repositories up to date "+gitRepositoriesUpToDate.Count().ToString()+", update to date repositories are : "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesUpToDate)+vbCrLf+
						"Number of repositories updated "+gitRepositoriesUpdated.Count().ToString()+", updated repositories are : "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesUpdated)+vbCrLf+
						"Number of repositories with changes not staged for commit "+gitRepositoriesWithCommits.Count().ToString()+" these repositories were nut updated. Repositories are "+vbCrLf+String.Join(Environment.NewLine, gitRepositoriesWithCommits)
				)
		)
)