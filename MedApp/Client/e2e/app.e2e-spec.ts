import { MedAppClientPage } from './app.po';

describe('med-app-client App', () => {
  let page: MedAppClientPage;

  beforeEach(() => {
    page = new MedAppClientPage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
