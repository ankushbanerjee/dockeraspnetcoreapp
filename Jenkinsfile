pipeline{

	agent any

	environment {
		DOCKERHUB_CREDENTIALS=credentials('dockerhub')
	}

	stages {

		/*stage('Build') {

			steps {
				sh 'docker build -t aspnetapp .'
			}
		}*/

		stage('Login') {

			steps {
				
                sh 'docker --version'
				sh 'echo $DOCKERHUB_CREDENTIALS_PSW | docker login -u $DOCKERHUB_CREDENTIALS_USR --password-stdin'
			}
		}

		stage('Push') {

			steps {
				sh 'docker push ankushbanerjee/dockeraspnetcoreapp'
			}
		}
	}

	post {
		always {
			sh 'docker logout'
		}
	}

}