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
				sh 'docker login -u ankushbanerjee'
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