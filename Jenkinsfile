pipeline {
  agent {
    docker {
      label 'docker'
      image 'microsoft/dotnet'
    }
  }
  stages {
    stage('Build') {
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      when {
        branch 'master'
      }
      steps {
        retry(3) {
          sh 'git clean -fdx'
          sh 'dotnet restore -s https://api.bintray.com/nuget/fint/nuget'
        }
        sh 'dotnet build -c Release'
        sh 'dotnet pack -c Release'
        archiveArtifacts '**/*.nupkg'
        sh "dotnet nuget push FINT.Model.Administrasjon/bin/Release/FINT.Model.Administrasjon.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}
